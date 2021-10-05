using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class viewmembers : Form
    {
        public viewmembers()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closeAdd_Click(object sender, EventArgs e)
        {
            homeform hom = new homeform();
            hom.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9G2BI4L\MSSQLSERVER01;Initial Catalog=zymDb;Integrated Security=True");
        private void populate()
        {
            con.Open();
            string query = "select * from addMemberTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            viewGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        private void viewmembers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void backview_Click(object sender, EventArgs e)
        {
            homeform hom = new homeform();
            hom.Show();
            this.Hide();
        }

        private void viewGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchview_Click(object sender, EventArgs e)
        {
            if(search.Text == "")
            {
                MessageBox.Show("Please Enter into the Field");
                viewmembers reload = new viewmembers();
                reload.Show();
            }
            else
            {
                try
                {
                    con.Open();
                    string search_query = "select * from addMemberTable where M_phone = '" + search.Text + "'";
                    SqlDataAdapter search_sda = new SqlDataAdapter(search_query, con);
                    SqlCommandBuilder search_builder = new SqlCommandBuilder();
                    var sds = new DataSet();
                    search_sda.Fill(sds);
                    viewGridView.DataSource = sds.Tables[0];
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            con.Open();
            string query = "select * from addMemberTable where M_phone = '"+ search.Text + "' OR MId = '" + search.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            viewGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void clears_Click(object sender, EventArgs e)
        {
            search.Text = "";
            viewmembers refresh = new viewmembers();
            refresh.Show();
        }
    }
}

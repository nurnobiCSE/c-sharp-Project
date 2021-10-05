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
    public partial class payments : Form
    {
        public payments()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9G2BI4L\MSSQLSERVER01;Initial Catalog=zymDb;Integrated Security=True");

        private void pay_Click(object sender, EventArgs e)
        {
            if (PaydateTime.Text == "" || payname.Text == "" || payphone.Text == "" || payammount.Text == "")
            {
                MessageBox.Show("Missing Information Please check all fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into paymentTable values('" + payname.Text + "','" + payphone.Text + "','" + payammount.Text + "','" + PaydateTime.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Payment");
                    con.Close();
                    populate_payment();
                    payname.Text = "";
                    payphone.Text = "";
                    payammount.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void populate_payment()
        {
            con.Open();
            string query = "select * from paymentTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            paymentGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void payments_Load(object sender, EventArgs e)
        {
            populate_payment();
        }

        private void paymentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void closeAdd_Click(object sender, EventArgs e)
        {
            homeform hom = new homeform();
            hom.Show();
            this.Hide();
        }

        private void backpay_Click(object sender, EventArgs e)
        {
            homeform hom = new homeform();
            hom.Show();
            this.Hide();
        }

        private void resetpay_Click(object sender, EventArgs e)
        {
            payname.Text = "";
            payphone.Text = "";
            payammount.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test
{
    public partial class addpage : Form
    {
        public addpage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9G2BI4L\MSSQLSERVER01;Initial Catalog=zymDb;Integrated Security=True");
        private void addpage_Load(object sender, EventArgs e)
        {

        }

        private void addmember_Click(object sender, EventArgs e)
        {

            if (name.Text == "" || phone.Text == "" || age.Text == "" || gender.Text == "" || ammount.Text == "" || timing.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            
            else
            {
                
                try {
                    con.Open();
                    string query = "insert into addMemberTable values('"+ name.Text + "','" + phone.Text + "','" + gender.SelectedItem.ToString()+ "','" + age.Text + "','" + timing.SelectedItem.ToString() + "','" + ammount.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added \n Thank You");
                    con.Close();
                    name.Text = "";
                    phone.Text = "";
                    gender.Text = "";
                    age.Text = "";
                    timing.Text = "";
                    ammount.Text = "";
                } catch (Exception Ex) {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void resetadd_Click(object sender, EventArgs e)
        {
            name.Text = "";
            phone.Text = "";
            gender.Text = "";
            age.Text = "";
            timing.Text = "";
            ammount.Text = "";
        }

        private void closeAdd_Click(object sender, EventArgs e)
        {
            homeform homefrom = new homeform();
            homefrom.Show();
            this.Hide();
        }

        private void backAdd_Click(object sender, EventArgs e)
        {
            homeform homefrom = new homeform();
            homefrom.Show();
            this.Hide();
        }
    }
}

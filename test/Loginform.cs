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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
            this.Text = "FITNESS CENTER";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9G2BI4L\MSSQLSERVER01;Initial Catalog=zymDb;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (userName.Text == "" || password.Text == "")
            {
                MessageBox.Show("please enter username and password");
            }
            else if(userName.Text == "admin" && password.Text == "admin")
            {
                MessageBox.Show("LogIn successfully!");
                homeform hom = new homeform();
                hom.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void clears_Click(object sender, EventArgs e)
        {
            userName.Text = "";
            password.Text = "";
        }
    }
}

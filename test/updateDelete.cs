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
    public partial class updateDelete : Form
    {
        public updateDelete()
        {
            InitializeComponent();
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
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
          
        }
        private void updateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void updateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void resetupdate_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            name.Text = "";
            phone.Text = "";
            gender.Text = "";
            age.Text = "";
            timing.Text = "";
            ammount.Text = "";
            searchtxt.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || phone.Text == "" || age.Text == "" || gender.Text == "" || ammount.Text == "" || timing.Text == "")
            {
                MessageBox.Show("Missing Information please check all fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update addMemberTable set updateDate='"+ DateTime.Parse(dateTimePicker1.Text) +"', M_name='" + name.Text + "',M_phone='" + phone.Text + "',M_gender='" + gender.Text + "',M_age='" + age.Text + "',M_timing='" + timing.Text + "',M_amount='" + ammount.Text + "' where MId='" + textBox1.Text + "' OR M_phone='" + int.Parse(textBox1.Text) + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Updated \n Thank You");
                    con.Close();
                    populate();
                    name.Text = "";
                    phone.Text = "";
                    gender.Text = "";
                    age.Text = "";
                    timing.Text = "";
                    ammount.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
       
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                MessageBox.Show("please insert member ID or phone number");
            
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from addMemberTable where MId = '" + textBox1.Text + "' OR M_phone = '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data has been deleted!");
                    textBox1.Text = "";
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Mid = 0;
            Mid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            gender.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            age.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            timing.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ammount.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void backupdate_Click(object sender, EventArgs e)
        {
            homeform hom = new homeform();
            hom.Show();
            this.Hide();
        }

        private void finding_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from addMemberTable where M_phone = '"+ searchtxt.Text +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}

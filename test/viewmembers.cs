using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(viewGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(viewGridView.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in viewGridView.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                               
                            }
                            
                            foreach (DataGridViewRow row in viewGridView.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        
                 
        }
    }
}

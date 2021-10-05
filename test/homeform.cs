using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace test
{
    public partial class homeform : Form
    {
        public homeform()
        {
            InitializeComponent();
        }

        private void homeform_Load(object sender, EventArgs e)
        {

        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            addpage addmember = new addpage();
            addmember.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            updateDelete edit = new updateDelete();
            edit.Show();
            this.Hide();
        }

        private void viewmember_Click(object sender, EventArgs e)
        {
            viewmembers sho_all = new viewmembers();
            sho_all.Show();
            this.Hide();
        }

        private void payment_Click(object sender, EventArgs e)
        {
            payments pay_option = new payments();
            pay_option.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Loginform login = new Loginform();
            login.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=CllgCHrkVbcpVBlxFgjzppwJQjbSwcRqhplrfgkxnSpjsdZCcqRPgLzFkjBSjHdGNZFtrQMCZTL");
        }
    }
}

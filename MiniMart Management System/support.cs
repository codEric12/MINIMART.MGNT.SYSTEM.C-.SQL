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

namespace MiniMart_Management_System
{
    public partial class supportForm : Form
    {
        public supportForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=new");
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            var TabsForm = new TabsForm();
            TabsForm.Show();
            Visible = false;
        }

        private void button_home_MouseEnter(object sender, EventArgs e)
        {
            button_home.ForeColor = Color.Red;
        }

        private void button_home_MouseLeave(object sender, EventArgs e)
        {
            button_home.ForeColor = Color.Yellow;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            LoginForm.Show();
            Visible = false;
        }

        private void button_logout_MouseEnter(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Red;
        }

        private void button_logout_MouseLeave(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Yellow;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Black;
        }
    }
}

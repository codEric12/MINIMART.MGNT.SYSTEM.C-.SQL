using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart_Management_System
{
    public partial class TabsForm : Form
    {
        public TabsForm()
        {
            InitializeComponent();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            var CategoryForm = new CategoryForm();
            CategoryForm.Show();
            Visible = false;
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            var ProductsForm = new ProductsForm();
            ProductsForm.Show();
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            LoginForm.Show();
            Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var LoginForm = new SellerForm();
            LoginForm.Show();
            Visible = false;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.ForeColor = Color.Red;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.ForeColor = Color.Yellow;
        }

        private void button_sellersview_Click(object sender, EventArgs e)
        {
            var sellersmonitorForm = new sellersmonitorForm();
            sellersmonitorForm.Show();
            Visible = false;
        }

        private void button_Support_Click(object sender, EventArgs e)
        {
             var supportForm = new supportForm();
            supportForm.Show();
            Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP_OOPCafeteriaSystem
{
    public partial class ExistingAccount : Form
    {
        public ExistingAccount()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxName.Text)
             || string.IsNullOrWhiteSpace(txtboxUsername.Text)
             || string.IsNullOrWhiteSpace(txtboxPassword.Text))
            {
                MessageBox.Show("To proceed, please fill in all the needed information. Please try again.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show("Login successful!");

            Menu menu = new Menu(txtboxName.Text);
            menu.Show();
            this.Hide();
        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
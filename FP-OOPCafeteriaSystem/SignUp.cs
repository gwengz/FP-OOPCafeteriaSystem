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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnExit__su_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void btnSignup2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxName_su.Text)
                || string.IsNullOrWhiteSpace(txtboxUsername_su.Text)
                || string.IsNullOrWhiteSpace(txtboxPassword_su.Text))
            {
                MessageBox.Show("To proceed, please fill in all the " +
                    "needed information. Please try again.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            Menu menu = new Menu(txtboxName_su.Text);
            menu.Show();
            this.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}

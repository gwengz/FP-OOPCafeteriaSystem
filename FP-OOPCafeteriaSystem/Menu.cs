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
    public partial class Menu : Form
    {
        private string customerName;

        public Menu(string name)
        {
            InitializeComponent();
            customerName = name;   // store the name from SignUp/ExistingAccount
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // PASS the name to OrderForm
            OrderForm order = new OrderForm(customerName);
            order.Show();
        }
    }
}

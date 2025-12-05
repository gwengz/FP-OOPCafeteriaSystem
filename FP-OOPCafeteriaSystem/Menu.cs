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
        private string _customerName;

        public Menu(string customerName)
        {
            InitializeComponent();
            _customerName = customerName;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm(_customerName);
            order.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1(); 
            loginForm.Show();              
            this.Close();                 
        }

        private void btnAddcs_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(_customerName); 
            orderForm.Show();                      
        }
    }
}

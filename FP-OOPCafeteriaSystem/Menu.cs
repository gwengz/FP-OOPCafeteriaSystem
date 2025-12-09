using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FP_OOPCafeteriaSystem
{

    public partial class Menu : Form
    {
        private string _customerName;

        public static List<OrderHistory> HistoryList = new List<OrderHistory>();

        public Menu(string customerName)
        {
            InitializeComponent();
            _customerName = customerName;
            label3.Text = "WELCOME, " + _customerName + "!";
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(_customerName);
            orderForm.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History historyForm = new History();
            historyForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnAddcs_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
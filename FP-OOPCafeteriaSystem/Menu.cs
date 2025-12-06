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
    // Menu.cs (only relevant addition)
    // MENU.CS (no changes needed, your code is already correct)

    public partial class Menu : Form
    {
        private string _customerName;

        public static List<OrderHistory> HistoryList = new List<OrderHistory>();

        public Menu(string customerName)
        {
            InitializeComponent();
            _customerName = customerName;
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
    }
}
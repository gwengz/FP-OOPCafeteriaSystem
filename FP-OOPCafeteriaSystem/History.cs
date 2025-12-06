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
    // HISTORY.CS - Updated to use ListView named listHistory instead of DataGridView

    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            // Clear existing items and columns
            listHistory.Clear();

            // Set view to Details to show columns
            listHistory.View = View.Details;
            listHistory.FullRowSelect = true;
            listHistory.GridLines = true;

            // Add columns
            listHistory.Columns.Add("Order ID", 120);
            listHistory.Columns.Add("Customer Name", 150);
            listHistory.Columns.Add("Date & Time", 180);

            // Add items from the shared history list
            foreach (var h in Menu.HistoryList)
            {
                ListViewItem item = new ListViewItem($"Order ID: {h.OrderID}");
                item.SubItems.Add(h.CustomerName);
                item.SubItems.Add($"{h.DatePlaced:MM/dd/yyyy} ; {h.DatePlaced:h:mm tt}");
                listHistory.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class OrderHistory
    {
        public string OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime DatePlaced { get; set; }
    }
}

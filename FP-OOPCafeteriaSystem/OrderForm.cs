using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace FP_OOPCafeteriaSystem
{
    // OrderForm.cs
    public partial class OrderForm : Form
    {
        private string customerName;
        public OrderForm(string name)
        {
            InitializeComponent();
            customerName = name;

            cmbDrinks.Items.Add("Americano");
            cmbDrinks.Items.Add("Spanish Latte");
            cmbDrinks.Items.Add("Mocha");
            cmbDrinks.Items.Add("Vietnamese Latte");
            cmbDrinks.Items.Add("Macchiato");

            cmbTemperature.Items.Add("Hot");
            cmbTemperature.Items.Add("Cold");

            cmbTemperature.SelectedIndex = 0;
            cmbDrinks.SelectedIndex = 0;
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cmbDrinks.SelectedIndex == -1 ||
                cmbTemperature.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a drink and your choice of temperature");
                return;
            }

            string drink = cmbDrinks.SelectedItem.ToString();
            string temperature = cmbTemperature.SelectedItem.ToString();

            Random randomNumber = new Random();
            int orderNumber = randomNumber.Next(1, 50);

            DateTime now = DateTime.Now;

            // Add the order to the shared HistoryList
            Menu.HistoryList.Add(new OrderHistory
            {
                OrderID = orderNumber.ToString(),
                CustomerName = customerName,
                DatePlaced = now
            });

            string dateTime = now.ToString("MMMM dd, yyyy - hh:mm tt");

            MessageBox.Show(
            $"ORDER NUMBER: {orderNumber}\n\n" +
                "Customer: " + customerName + "\n\n" +
                $"Drink: {drink} - {temperature}\n" +
                $"Date & Time: {dateTime}",
                "ORDER PLACED SUCCESSFULLY!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

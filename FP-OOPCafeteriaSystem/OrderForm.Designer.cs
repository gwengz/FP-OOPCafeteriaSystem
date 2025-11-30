namespace FP_OOPCafeteriaSystem
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbDrinks = new ComboBox();
            cmbTemperature = new ComboBox();
            btnPlaceOrder = new Button();
            label1 = new Label();
            label2 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // cmbDrinks
            // 
            cmbDrinks.FormattingEnabled = true;
            cmbDrinks.Items.AddRange(new object[] { "Americano", "Spanish Latte", "Mocha", "Vietnamese Latte", "Macchiato" });
            cmbDrinks.Location = new Point(56, 130);
            cmbDrinks.Name = "cmbDrinks";
            cmbDrinks.Size = new Size(151, 31);
            cmbDrinks.TabIndex = 0;
            // 
            // cmbTemperature
            // 
            cmbTemperature.FormattingEnabled = true;
            cmbTemperature.Items.AddRange(new object[] { "Hot", "Cold" });
            cmbTemperature.Location = new Point(250, 130);
            cmbTemperature.Name = "cmbTemperature";
            cmbTemperature.Size = new Size(151, 31);
            cmbTemperature.TabIndex = 1;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(325, 241);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(117, 38);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 89);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 3;
            label1.Text = "Choose a drink";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 89);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 4;
            label2.Text = "Temperature";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(68, 35);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 291);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPlaceOrder);
            Controls.Add(cmbTemperature);
            Controls.Add(cmbDrinks);
            Name = "OrderForm";
            Text = "OrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDrinks;
        private ComboBox cmbTemperature;
        private Button btnPlaceOrder;
        private Label label1;
        private Label label2;
        private Button btnBack;
    }
}
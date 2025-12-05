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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
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
            cmbDrinks.Location = new Point(44, 85);
            cmbDrinks.Margin = new Padding(2);
            cmbDrinks.Name = "cmbDrinks";
            cmbDrinks.Size = new Size(118, 23);
            cmbDrinks.TabIndex = 0;
            // 
            // cmbTemperature
            // 
            cmbTemperature.FormattingEnabled = true;
            cmbTemperature.Location = new Point(194, 85);
            cmbTemperature.Margin = new Padding(2);
            cmbTemperature.Name = "cmbTemperature";
            cmbTemperature.Size = new Size(118, 23);
            cmbTemperature.TabIndex = 1;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(253, 157);
            btnPlaceOrder.Margin = new Padding(2);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(91, 25);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tan;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            label1.Location = new Point(51, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 3;
            label1.Text = "Choose a drink";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Tan;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            label2.Location = new Point(212, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 4;
            label2.Text = "Temperature";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(9, 8);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(53, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(351, 186);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPlaceOrder);
            Controls.Add(cmbTemperature);
            Controls.Add(cmbDrinks);
            Margin = new Padding(2);
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
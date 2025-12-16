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
            cmbDrinks.Location = new Point(41, 90);
            cmbDrinks.Margin = new Padding(2, 2, 2, 2);
            cmbDrinks.Name = "cmbDrinks";
            cmbDrinks.Size = new Size(164, 23);
            cmbDrinks.TabIndex = 0;
            // 
            // cmbTemperature
            // 
            cmbTemperature.FormattingEnabled = true;
            cmbTemperature.Location = new Point(222, 90);
            cmbTemperature.Margin = new Padding(2, 2, 2, 2);
            cmbTemperature.Name = "cmbTemperature";
            cmbTemperature.Size = new Size(164, 23);
            cmbTemperature.TabIndex = 1;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Font = new Font("Lucida Fax", 10.8F, FontStyle.Bold);
            btnPlaceOrder.Location = new Point(297, 184);
            btnPlaceOrder.Margin = new Padding(2, 2, 2, 2);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(118, 37);
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
            label1.Location = new Point(41, 63);
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
            label2.Location = new Point(222, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 4;
            label2.Text = "Temperature";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Lucida Fax", 10.8F, FontStyle.Bold);
            btnBack.Location = new Point(9, 8);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(67, 23);
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
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(452, 252);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPlaceOrder);
            Controls.Add(cmbTemperature);
            Controls.Add(cmbDrinks);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "OrderForm";
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
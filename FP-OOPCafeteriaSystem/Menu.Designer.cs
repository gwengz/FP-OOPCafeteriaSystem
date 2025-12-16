namespace FP_OOPCafeteriaSystem
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnHistory = new Button();
            btnAddcs = new Button();
            btnMakeOrder = new Button();
            btnLogout = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Lucida Fax", 9F);
            btnHistory.Location = new Point(88, 255);
            btnHistory.Margin = new Padding(2, 2, 2, 2);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(327, 26);
            btnHistory.TabIndex = 15;
            btnHistory.Text = "View history";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnAddcs
            // 
            btnAddcs.Font = new Font("Lucida Fax", 9F);
            btnAddcs.Location = new Point(87, 195);
            btnAddcs.Margin = new Padding(2, 2, 2, 2);
            btnAddcs.Name = "btnAddcs";
            btnAddcs.Size = new Size(328, 26);
            btnAddcs.TabIndex = 2;
            btnAddcs.Text = "Add customer";
            btnAddcs.UseVisualStyleBackColor = true;
            btnAddcs.Click += btnAddcs_Click;
            // 
            // btnMakeOrder
            // 
            btnMakeOrder.Font = new Font("Lucida Fax", 9F);
            btnMakeOrder.Location = new Point(87, 225);
            btnMakeOrder.Margin = new Padding(2, 2, 2, 2);
            btnMakeOrder.Name = "btnMakeOrder";
            btnMakeOrder.Size = new Size(328, 26);
            btnMakeOrder.TabIndex = 3;
            btnMakeOrder.Text = "Make an order";
            btnMakeOrder.UseVisualStyleBackColor = true;
            btnMakeOrder.Click += btnMakeOrder_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ScrollBar;
            btnLogout.Font = new Font("Lucida Fax", 9F);
            btnLogout.Location = new Point(184, 305);
            btnLogout.Margin = new Padding(2, 2, 2, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 26);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 102);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(488, 66);
            label4.TabIndex = 14;
            label4.Text = "In Caffeinity, we blend innovation and reliabity, ensuring every \r\ncoffee lover enjoys easy access to add customer, record and for \r\nyou to check history.";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(168, 71);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 26);
            label3.TabIndex = 17;
            label3.Text = "(greetings)";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(9, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 37);
            label1.TabIndex = 18;
            label1.Text = "MENU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(9, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(251, 22);
            label2.TabIndex = 6;
            label2.Text = "How would you like to proceed?";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(516, 348);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnHistory);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnLogout);
            Controls.Add(btnMakeOrder);
            Controls.Add(btnAddcs);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Menu";
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion
        private Button btnAddcs;
        private Button btnMakeOrder;
        private Button btnLogout;
        private Label label4;
        private Button btnHistory;
        public Label label3;
        private Label label1;
        private Label label2;
    }
}
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
            btnAddcs = new Button();
            btnMakeOrder = new Button();
            btnLogout = new Button();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAddcs
            // 
            btnAddcs.Location = new Point(19, 149);
            btnAddcs.Margin = new Padding(2);
            btnAddcs.Name = "btnAddcs";
            btnAddcs.Size = new Size(278, 26);
            btnAddcs.TabIndex = 2;
            btnAddcs.Text = "Add customer";
            btnAddcs.UseVisualStyleBackColor = true;
            btnAddcs.Click += btnAddcs_Click;
            // 
            // btnMakeOrder
            // 
            btnMakeOrder.Location = new Point(19, 179);
            btnMakeOrder.Margin = new Padding(2);
            btnMakeOrder.Name = "btnMakeOrder";
            btnMakeOrder.Size = new Size(278, 26);
            btnMakeOrder.TabIndex = 3;
            btnMakeOrder.Text = "Make an order";
            btnMakeOrder.UseVisualStyleBackColor = true;
            btnMakeOrder.Click += btnMakeOrder_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ScrollBar;
            btnLogout.Location = new Point(19, 239);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(278, 26);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 116);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(302, 26);
            label2.TabIndex = 6;
            label2.Text = "How would you like to proceed?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 6);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(270, 110);
            label4.TabIndex = 14;
            label4.Text = "In Caffeinity, we blend innovation \r\nand reliabity, ensuring every \r\ncoffee lover enjoys easy access to\r\nadd customer, record\r\nand for you to check history.";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 293);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnLogout);
            Controls.Add(btnMakeOrder);
            Controls.Add(btnAddcs);
            Margin = new Padding(2);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddcs;
        private Button btnMakeOrder;
        private Button btnLogout;
        private Label label2;
        private Label label4;
    }
}
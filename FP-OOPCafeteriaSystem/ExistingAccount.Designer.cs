namespace FP_OOPCafeteriaSystem
{
    partial class ExistingAccount
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
            txtboxName = new TextBox();
            btnLogin2 = new Button();
            btnExit_login = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtboxUsername = new TextBox();
            txtboxPassword = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtboxName
            // 
            txtboxName.Location = new Point(134, 55);
            txtboxName.Margin = new Padding(2, 2, 2, 2);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(215, 23);
            txtboxName.TabIndex = 3;
            txtboxName.TextChanged += txtboxName_TextChanged;
            // 
            // btnLogin2
            // 
            btnLogin2.Location = new Point(205, 134);
            btnLogin2.Margin = new Padding(2, 2, 2, 2);
            btnLogin2.Name = "btnLogin2";
            btnLogin2.Size = new Size(74, 22);
            btnLogin2.TabIndex = 6;
            btnLogin2.Text = "Log In";
            btnLogin2.UseVisualStyleBackColor = true;
            btnLogin2.Click += btnLogin2_Click;
            // 
            // btnExit_login
            // 
            btnExit_login.Location = new Point(205, 159);
            btnExit_login.Margin = new Padding(2, 2, 2, 2);
            btnExit_login.Name = "btnExit_login";
            btnExit_login.Size = new Size(74, 22);
            btnExit_login.TabIndex = 7;
            btnExit_login.Text = "EXIT";
            btnExit_login.UseVisualStyleBackColor = true;
            btnExit_login.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 10.2F);
            label1.Location = new Point(58, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 8;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 10.2F);
            label2.Location = new Point(58, 83);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 9;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 10.2F);
            label3.Location = new Point(58, 107);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 10;
            label3.Text = "Password:";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Location = new Point(134, 79);
            txtboxUsername.Margin = new Padding(2, 2, 2, 2);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(215, 23);
            txtboxUsername.TabIndex = 11;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Location = new Point(134, 102);
            txtboxPassword.Margin = new Padding(2, 2, 2, 2);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(215, 23);
            txtboxPassword.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 20);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 22);
            label4.TabIndex = 23;
            label4.Text = "Please log in";
            // 
            // ExistingAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 208);
            Controls.Add(label4);
            Controls.Add(txtboxPassword);
            Controls.Add(txtboxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit_login);
            Controls.Add(btnLogin2);
            Controls.Add(txtboxName);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ExistingAccount";
            Text = "LOGIN FORM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtboxName;
        private Button btnLogin2;
        private Button btnExit_login;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtboxUsername;
        private TextBox txtboxPassword;
        private Label label4;
    }
}
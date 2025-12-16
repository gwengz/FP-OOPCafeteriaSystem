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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExistingAccount));
            txtboxName = new TextBox();
            btnLogin2 = new Button();
            btnExit_login = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtboxUsername = new TextBox();
            txtboxPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtboxName
            // 
            txtboxName.Location = new Point(151, 90);
            txtboxName.Margin = new Padding(2, 2, 2, 2);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(215, 23);
            txtboxName.TabIndex = 3;
            txtboxName.TextAlign = HorizontalAlignment.Center;
            txtboxName.TextChanged += txtboxName_TextChanged;
            // 
            // btnLogin2
            // 
            btnLogin2.BackColor = SystemColors.ActiveBorder;
            btnLogin2.Font = new Font("Lucida Fax", 10.2F);
            btnLogin2.Location = new Point(222, 241);
            btnLogin2.Margin = new Padding(2, 2, 2, 2);
            btnLogin2.Name = "btnLogin2";
            btnLogin2.Size = new Size(74, 27);
            btnLogin2.TabIndex = 6;
            btnLogin2.Text = "Log In";
            btnLogin2.UseVisualStyleBackColor = false;
            btnLogin2.Click += btnLogin2_Click;
            // 
            // btnExit_login
            // 
            btnExit_login.BackColor = SystemColors.Menu;
            btnExit_login.Font = new Font("Lucida Fax", 10.2F);
            btnExit_login.Location = new Point(9, 286);
            btnExit_login.Margin = new Padding(2, 2, 2, 2);
            btnExit_login.Name = "btnExit_login";
            btnExit_login.Size = new Size(74, 22);
            btnExit_login.TabIndex = 7;
            btnExit_login.Text = "EXIT";
            btnExit_login.UseVisualStyleBackColor = false;
            btnExit_login.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(236, 112);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 16);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(219, 158);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 16);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(224, 204);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 16);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Location = new Point(151, 137);
            txtboxUsername.Margin = new Padding(2, 2, 2, 2);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(215, 23);
            txtboxUsername.TabIndex = 11;
            txtboxUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Location = new Point(151, 183);
            txtboxPassword.Margin = new Padding(2, 2, 2, 2);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.PasswordChar = '*';
            txtboxPassword.Size = new Size(215, 23);
            txtboxPassword.TabIndex = 12;
            txtboxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(9, 15);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(340, 25);
            label4.TabIndex = 23;
            label4.Text = "You are on the right track! :)";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(9, 63);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(322, 16);
            label5.TabIndex = 24;
            label5.Text = "Please fill out all the information needed. ";
            // 
            // ExistingAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(514, 316);
            Controls.Add(label5);
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
        private Label label5;
    }
}
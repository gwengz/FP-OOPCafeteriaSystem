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
            txtboxName.Location = new Point(194, 138);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(275, 30);
            txtboxName.TabIndex = 3;
            txtboxName.TextChanged += txtboxName_TextChanged;
            // 
            // btnLogin2
            // 
            btnLogin2.BackColor = SystemColors.ActiveBorder;
            btnLogin2.Font = new Font("Lucida Fax", 10.2F);
            btnLogin2.Location = new Point(285, 370);
            btnLogin2.Name = "btnLogin2";
            btnLogin2.Size = new Size(95, 34);
            btnLogin2.TabIndex = 6;
            btnLogin2.Text = "Log In";
            btnLogin2.UseVisualStyleBackColor = false;
            btnLogin2.Click += btnLogin2_Click;
            // 
            // btnExit_login
            // 
            btnExit_login.BackColor = SystemColors.Menu;
            btnExit_login.Font = new Font("Lucida Fax", 10.2F);
            btnExit_login.Location = new Point(12, 438);
            btnExit_login.Name = "btnExit_login";
            btnExit_login.Size = new Size(95, 34);
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
            label1.Location = new Point(303, 171);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(281, 243);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(288, 313);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Location = new Point(194, 210);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(275, 30);
            txtboxUsername.TabIndex = 11;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Location = new Point(194, 280);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.PasswordChar = '*';
            txtboxPassword.Size = new Size(275, 30);
            txtboxPassword.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 23);
            label4.Name = "label4";
            label4.Size = new Size(435, 32);
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
            label5.Location = new Point(12, 97);
            label5.Name = "label5";
            label5.Size = new Size(395, 20);
            label5.TabIndex = 24;
            label5.Text = "Please fill out all the information needed. ";
            // 
            // ExistingAccount
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(661, 484);
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
namespace FP_OOPCafeteriaSystem
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            txtboxPassword_su = new TextBox();
            txtboxUsername_su = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnExit__su = new Button();
            btnSignup2 = new Button();
            txtboxName_su = new TextBox();
            label5 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtboxPassword_su
            // 
            txtboxPassword_su.Location = new Point(216, 311);
            txtboxPassword_su.Name = "txtboxPassword_su";
            txtboxPassword_su.PasswordChar = '*';
            txtboxPassword_su.Size = new Size(275, 30);
            txtboxPassword_su.TabIndex = 21;
            // 
            // txtboxUsername_su
            // 
            txtboxUsername_su.Location = new Point(216, 228);
            txtboxUsername_su.Name = "txtboxUsername_su";
            txtboxUsername_su.Size = new Size(275, 30);
            txtboxUsername_su.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(310, 344);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 19;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(307, 261);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 18;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(323, 179);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // btnExit__su
            // 
            btnExit__su.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit__su.Location = new Point(12, 450);
            btnExit__su.Name = "btnExit__su";
            btnExit__su.Size = new Size(95, 34);
            btnExit__su.TabIndex = 16;
            btnExit__su.Text = "EXIT";
            btnExit__su.UseVisualStyleBackColor = true;
            btnExit__su.Click += btnExit__su_Click;
            // 
            // btnSignup2
            // 
            btnSignup2.BackColor = SystemColors.ActiveBorder;
            btnSignup2.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignup2.Location = new Point(307, 393);
            btnSignup2.Name = "btnSignup2";
            btnSignup2.Size = new Size(95, 34);
            btnSignup2.TabIndex = 15;
            btnSignup2.Text = "Sign Up";
            btnSignup2.UseVisualStyleBackColor = false;
            btnSignup2.Click += btnSignup2_Click;
            // 
            // txtboxName_su
            // 
            txtboxName_su.Location = new Point(216, 146);
            txtboxName_su.Name = "txtboxName_su";
            txtboxName_su.Size = new Size(275, 30);
            txtboxName_su.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Fax", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(12, 106);
            label5.Name = "label5";
            label5.Size = new Size(407, 21);
            label5.TabIndex = 23;
            label5.Text = "Please fill out all the information needed.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 21);
            label4.Name = "label4";
            label4.Size = new Size(435, 32);
            label4.TabIndex = 24;
            label4.Text = "You are on the right track! :)";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(708, 496);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtboxPassword_su);
            Controls.Add(txtboxUsername_su);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit__su);
            Controls.Add(btnSignup2);
            Controls.Add(txtboxName_su);
            Name = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtboxPassword_su;
        private TextBox txtboxUsername_su;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnExit__su;
        private Button btnSignup2;
        private TextBox txtboxName_su;
        private Label label5;
        private Label label4;
    }
}
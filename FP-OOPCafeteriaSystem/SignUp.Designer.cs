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
            label4 = new Label();
            txtboxPassword_su = new TextBox();
            txtboxUsername_su = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnExit__su = new Button();
            btnSignup2 = new Button();
            txtboxName_su = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 28);
            label4.Name = "label4";
            label4.Size = new Size(140, 27);
            label4.TabIndex = 22;
            label4.Text = "Please sign up";
            // 
            // txtboxPassword_su
            // 
            txtboxPassword_su.Location = new Point(171, 159);
            txtboxPassword_su.Name = "txtboxPassword_su";
            txtboxPassword_su.Size = new Size(275, 30);
            txtboxPassword_su.TabIndex = 21;
            // 
            // txtboxUsername_su
            // 
            txtboxUsername_su.Location = new Point(171, 123);
            txtboxUsername_su.Name = "txtboxUsername_su";
            txtboxUsername_su.Size = new Size(275, 30);
            txtboxUsername_su.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 10.8F);
            label3.Location = new Point(74, 166);
            label3.Name = "label3";
            label3.Size = new Size(89, 24);
            label3.TabIndex = 19;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 10.8F);
            label2.Location = new Point(74, 130);
            label2.Name = "label2";
            label2.Size = new Size(96, 24);
            label2.TabIndex = 18;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 10.8F);
            label1.Location = new Point(74, 94);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 17;
            label1.Text = "Name:";
            // 
            // btnExit__su
            // 
            btnExit__su.Location = new Point(258, 245);
            btnExit__su.Name = "btnExit__su";
            btnExit__su.Size = new Size(95, 33);
            btnExit__su.TabIndex = 16;
            btnExit__su.Text = "EXIT";
            btnExit__su.UseVisualStyleBackColor = true;
            btnExit__su.Click += btnExit__su_Click;
            // 
            // btnSignup2
            // 
            btnSignup2.Location = new Point(258, 206);
            btnSignup2.Name = "btnSignup2";
            btnSignup2.Size = new Size(95, 33);
            btnSignup2.TabIndex = 15;
            btnSignup2.Text = "Sign Up";
            btnSignup2.UseVisualStyleBackColor = true;
            btnSignup2.Click += btnSignup2_Click;
            // 
            // txtboxName_su
            // 
            txtboxName_su.Location = new Point(171, 87);
            txtboxName_su.Name = "txtboxName_su";
            txtboxName_su.Size = new Size(275, 30);
            txtboxName_su.TabIndex = 14;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 317);
            Controls.Add(label4);
            Controls.Add(txtboxPassword_su);
            Controls.Add(txtboxUsername_su);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit__su);
            Controls.Add(btnSignup2);
            Controls.Add(txtboxName_su);
            Name = "SignUp";
            Text = "SIGN UP FORM";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtboxPassword_su;
        private TextBox txtboxUsername_su;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnExit__su;
        private Button btnSignup2;
        private TextBox txtboxName_su;
    }
}
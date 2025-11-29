namespace FP_OOPCafeteriaSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSignUp = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(140, 100);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "LOG IN";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // button1
            // 
            button1.Location = new Point(140, 65);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 23);
            label1.TabIndex = 2;
            label1.Text = "How would you like to proceed?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 166);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnSignUp);
            Name = "Form1";
            Text = "Cafeteria System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private Button button1;
        private Label label1;
    }
}

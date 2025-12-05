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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLogin1 = new Button();
            btnSignup1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnLogin1
            // 
            btnLogin1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLogin1.Location = new Point(248, 177);
            btnLogin1.Margin = new Padding(2);
            btnLogin1.Name = "btnLogin1";
            btnLogin1.Size = new Size(113, 37);
            btnLogin1.TabIndex = 0;
            btnLogin1.Text = "LOG IN";
            btnLogin1.UseVisualStyleBackColor = true;
            btnLogin1.Click += btnLogin1_Click;
            // 
            // btnSignup1
            // 
            btnSignup1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSignup1.Location = new Point(120, 177);
            btnSignup1.Margin = new Padding(2);
            btnSignup1.Name = "btnSignup1";
            btnSignup1.Size = new Size(113, 37);
            btnSignup1.TabIndex = 1;
            btnSignup1.Text = "SIGN UP";
            btnSignup1.UseVisualStyleBackColor = true;
            btnSignup1.Click += btnSignup1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 13);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 22);
            label2.TabIndex = 3;
            label2.Text = "Welcome to Caffeignity!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(70, 149);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(377, 22);
            label3.TabIndex = 4;
            label3.Text = "Discover more by starting esspresso who you are!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 44);
            label1.TabIndex = 5;
            label1.Text = "Rich, bold, and irresistible smooth- \r\ncoffee that wakes your senses.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 8.25F);
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Location = new Point(437, 7);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(47, 36);
            button1.TabIndex = 6;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(495, 231);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSignup1);
            Controls.Add(btnLogin1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Cafeteria System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin1;
        private Button btnSignup1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button button1;

    }
}

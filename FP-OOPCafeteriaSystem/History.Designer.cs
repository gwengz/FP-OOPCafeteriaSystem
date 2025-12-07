namespace FP_OOPCafeteriaSystem
{
    partial class History
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
            button1 = new Button();
            listHistory = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 16);
            button1.Name = "button1";
            button1.Size = new Size(96, 49);
            button1.TabIndex = 1;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listHistory
            // 
            listHistory.Location = new Point(22, 83);
            listHistory.Name = "listHistory";
            listHistory.Size = new Size(771, 186);
            listHistory.TabIndex = 2;
            listHistory.UseCompatibleStateImageBehavior = false;
            listHistory.SelectedIndexChanged += listHistory_SelectedIndexChanged;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 349);
            Controls.Add(listHistory);
            Controls.Add(button1);
            Name = "History";
            Text = "History";
            Load += History_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ListView listHistory;
    }
}
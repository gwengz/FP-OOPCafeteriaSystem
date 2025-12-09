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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            button1 = new Button();
            listHistory = new ListView();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(543, 12);
            button1.Name = "button1";
            button1.Size = new Size(72, 39);
            button1.TabIndex = 1;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listHistory
            // 
            listHistory.Location = new Point(22, 90);
            listHistory.Name = "listHistory";
            listHistory.Size = new Size(583, 186);
            listHistory.TabIndex = 2;
            listHistory.UseCompatibleStateImageBehavior = false;
            listHistory.View = View.List;
            listHistory.SelectedIndexChanged += listHistory_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(22, 19);
            label4.Name = "label4";
            label4.Size = new Size(245, 32);
            label4.TabIndex = 24;
            label4.Text = "TRANSACTIONS";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(627, 299);
            Controls.Add(label4);
            Controls.Add(listHistory);
            Controls.Add(button1);
            Name = "History";
            Load += History_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListView listHistory;
        private Label label4;
    }
}
namespace LibraryManagmentSystem
{
    partial class dashPan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashPan));
            panel1 = new Panel();
            panel4 = new Panel();
            txtIssuedBookCount = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            txtBookCount = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txtMemCount = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(26, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 207);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(211, 187, 237);
            panel4.Controls.Add(txtIssuedBookCount);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(513, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(214, 161);
            panel4.TabIndex = 2;
            // 
            // txtIssuedBookCount
            // 
            txtIssuedBookCount.AutoSize = true;
            txtIssuedBookCount.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIssuedBookCount.ForeColor = SystemColors.ButtonHighlight;
            txtIssuedBookCount.Location = new Point(166, 107);
            txtIssuedBookCount.Name = "txtIssuedBookCount";
            txtIssuedBookCount.Size = new Size(35, 41);
            txtIssuedBookCount.TabIndex = 4;
            txtIssuedBookCount.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 76);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 67);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(82, 21);
            label3.Name = "label3";
            label3.Size = new Size(119, 24);
            label3.TabIndex = 1;
            label3.Text = "Issued Books";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(211, 187, 237);
            panel3.Controls.Add(txtBookCount);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(268, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 161);
            panel3.TabIndex = 1;
            // 
            // txtBookCount
            // 
            txtBookCount.AutoSize = true;
            txtBookCount.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookCount.ForeColor = SystemColors.ButtonHighlight;
            txtBookCount.Location = new Point(165, 107);
            txtBookCount.Name = "txtBookCount";
            txtBookCount.Size = new Size(35, 41);
            txtBookCount.TabIndex = 4;
            txtBookCount.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(99, 21);
            label2.Name = "label2";
            label2.Size = new Size(88, 24);
            label2.TabIndex = 1;
            label2.Text = "All Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(211, 187, 237);
            panel2.Controls.Add(txtMemCount);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(22, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 161);
            panel2.TabIndex = 0;
            // 
            // txtMemCount
            // 
            txtMemCount.AutoSize = true;
            txtMemCount.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMemCount.ForeColor = SystemColors.ButtonHighlight;
            txtMemCount.Location = new Point(166, 107);
            txtMemCount.Name = "txtMemCount";
            txtMemCount.Size = new Size(35, 41);
            txtMemCount.TabIndex = 3;
            txtMemCount.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(76, 21);
            label1.Name = "label1";
            label1.Size = new Size(116, 24);
            label1.TabIndex = 0;
            label1.Text = "All Members";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 263);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(749, 331);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // dashPan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 230, 254);
            ClientSize = new Size(803, 625);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashPan";
            Text = "dashPan";
            Load += dashPan_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label txtIssuedBookCount;
        private Label txtBookCount;
        private Label txtMemCount;
        private PictureBox pictureBox4;
    }
}
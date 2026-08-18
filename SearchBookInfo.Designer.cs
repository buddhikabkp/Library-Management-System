namespace LibraryManagmentSystem
{
    partial class SearchBookInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBookInfo));
            txtExit = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblBookID = new Label();
            lblBookTitle = new Label();
            lblAuthor = new Label();
            lblLanguage = new Label();
            lblCategory = new Label();
            lblISBN = new Label();
            lblAvailability = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtExit
            // 
            txtExit.AutoSize = true;
            txtExit.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExit.ForeColor = SystemColors.ButtonHighlight;
            txtExit.Location = new Point(759, 6);
            txtExit.Name = "txtExit";
            txtExit.Size = new Size(20, 22);
            txtExit.TabIndex = 20;
            txtExit.Text = "X";
            txtExit.Click += txtExit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label7.Location = new Point(426, 455);
            label7.Name = "label7";
            label7.Size = new Size(103, 18);
            label7.TabIndex = 48;
            label7.Text = "Availability :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label6.Location = new Point(426, 374);
            label6.Name = "label6";
            label6.Size = new Size(85, 18);
            label6.TabIndex = 46;
            label6.Text = "Category :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label5.Location = new Point(426, 416);
            label5.Name = "label5";
            label5.Size = new Size(56, 18);
            label5.TabIndex = 44;
            label5.Text = "ISBN :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(426, 332);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 43;
            label4.Text = "Language :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(71, 455);
            label3.Name = "label3";
            label3.Size = new Size(108, 18);
            label3.TabIndex = 41;
            label3.Text = "Book Author :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.Location = new Point(71, 397);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 39;
            label2.Text = "Book Title :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label1.Location = new Point(71, 332);
            label1.Name = "label1";
            label1.Size = new Size(76, 18);
            label1.TabIndex = 37;
            label1.Text = "Book ID :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(182, 149, 222);
            panel1.Controls.Add(txtExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 35);
            panel1.TabIndex = 51;
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookID.Location = new Point(163, 332);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(56, 18);
            lblBookID.TabIndex = 52;
            lblBookID.Text = "BookID";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookTitle.Location = new Point(179, 397);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(67, 18);
            lblBookTitle.TabIndex = 53;
            lblBookTitle.Text = "BookTitle";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(196, 455);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(51, 18);
            lblAuthor.TabIndex = 54;
            lblAuthor.Text = "Author";
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLanguage.Location = new Point(521, 332);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(71, 18);
            lblLanguage.TabIndex = 55;
            lblLanguage.Text = "Language";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(532, 374);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(67, 18);
            lblCategory.TabIndex = 56;
            lblCategory.Text = "Category";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(488, 416);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 18);
            lblISBN.TabIndex = 57;
            lblISBN.Text = "ISBN";
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailability.Location = new Point(535, 455);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(72, 18);
            lblAvailability.TabIndex = 58;
            lblAvailability.Text = "Availability";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(298, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // SearchBookInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 230, 254);
            ClientSize = new Size(785, 578);
            Controls.Add(pictureBox1);
            Controls.Add(lblAvailability);
            Controls.Add(lblISBN);
            Controls.Add(lblCategory);
            Controls.Add(lblLanguage);
            Controls.Add(lblAuthor);
            Controls.Add(lblBookTitle);
            Controls.Add(lblBookID);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchBookInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchBookInfo";
            Load += SearchBookInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtExit;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label lblBookID;
        private Label lblBookTitle;
        private Label lblAuthor;
        private Label lblLanguage;
        private Label lblCategory;
        private Label lblISBN;
        private Label lblAvailability;
        private PictureBox pictureBox1;
    }
}
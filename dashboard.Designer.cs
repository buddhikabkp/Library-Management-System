namespace LibraryManagmentSystem
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            panel1 = new Panel();
            label5 = new Label();
            txtExit = new Label();
            panel2 = new Panel();
            btnReturnBook = new Button();
            btnLoanBook = new Button();
            btnLogout = new Button();
            btnMemReg = new Button();
            btnBookReg = new Button();
            btnInqBook = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(182, 149, 222);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 35);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(9, 6);
            label5.Name = "label5";
            label5.Size = new Size(211, 21);
            label5.TabIndex = 1;
            label5.Text = "Library Managment System";
            // 
            // txtExit
            // 
            txtExit.AutoSize = true;
            txtExit.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExit.ForeColor = SystemColors.ButtonHighlight;
            txtExit.Location = new Point(1072, 7);
            txtExit.Name = "txtExit";
            txtExit.Size = new Size(20, 22);
            txtExit.TabIndex = 19;
            txtExit.Text = "X";
            txtExit.Click += txtExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(182, 149, 222);
            panel2.Controls.Add(btnReturnBook);
            panel2.Controls.Add(btnLoanBook);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnMemReg);
            panel2.Controls.Add(btnBookReg);
            panel2.Controls.Add(btnInqBook);
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 625);
            panel2.TabIndex = 1;
            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = Color.FromArgb(182, 149, 222);
            btnReturnBook.FlatStyle = FlatStyle.Flat;
            btnReturnBook.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnReturnBook.ForeColor = SystemColors.ButtonHighlight;
            btnReturnBook.Location = new Point(27, 520);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(246, 41);
            btnReturnBook.TabIndex = 4;
            btnReturnBook.Text = "RETURN BOOK";
            btnReturnBook.UseVisualStyleBackColor = false;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnLoanBook
            // 
            btnLoanBook.BackColor = Color.FromArgb(182, 149, 222);
            btnLoanBook.FlatStyle = FlatStyle.Flat;
            btnLoanBook.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnLoanBook.ForeColor = SystemColors.ButtonHighlight;
            btnLoanBook.Location = new Point(27, 462);
            btnLoanBook.Name = "btnLoanBook";
            btnLoanBook.Size = new Size(246, 41);
            btnLoanBook.TabIndex = 3;
            btnLoanBook.Text = "LOAN BOOK";
            btnLoanBook.UseVisualStyleBackColor = false;
            btnLoanBook.Click += btnLoanBook_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(182, 149, 222);
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(27, 580);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(37, 33);
            btnLogout.TabIndex = 3;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMemReg
            // 
            btnMemReg.BackColor = Color.FromArgb(182, 149, 222);
            btnMemReg.FlatStyle = FlatStyle.Flat;
            btnMemReg.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnMemReg.ForeColor = SystemColors.ButtonHighlight;
            btnMemReg.Location = new Point(27, 285);
            btnMemReg.Name = "btnMemReg";
            btnMemReg.Size = new Size(246, 41);
            btnMemReg.TabIndex = 8;
            btnMemReg.Text = "MEMBER REGISTRATION";
            btnMemReg.UseVisualStyleBackColor = false;
            btnMemReg.Click += btnMemReg_Click;
            // 
            // btnBookReg
            // 
            btnBookReg.BackColor = Color.FromArgb(182, 149, 222);
            btnBookReg.FlatStyle = FlatStyle.Flat;
            btnBookReg.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnBookReg.ForeColor = SystemColors.ButtonHighlight;
            btnBookReg.Location = new Point(27, 343);
            btnBookReg.Name = "btnBookReg";
            btnBookReg.Size = new Size(246, 41);
            btnBookReg.TabIndex = 7;
            btnBookReg.Text = "BOOK REGISTRATION";
            btnBookReg.UseVisualStyleBackColor = false;
            btnBookReg.Click += btnBookReg_Click;
            // 
            // btnInqBook
            // 
            btnInqBook.BackColor = Color.FromArgb(182, 149, 222);
            btnInqBook.FlatStyle = FlatStyle.Flat;
            btnInqBook.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnInqBook.ForeColor = SystemColors.ButtonHighlight;
            btnInqBook.Location = new Point(27, 403);
            btnInqBook.Name = "btnInqBook";
            btnInqBook.Size = new Size(246, 41);
            btnInqBook.TabIndex = 5;
            btnInqBook.Text = "SEARCH BOOK";
            btnInqBook.UseVisualStyleBackColor = false;
            btnInqBook.Click += btnInqBook_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(182, 149, 222);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnDashboard.ForeColor = SystemColors.ButtonHighlight;
            btnDashboard.Location = new Point(27, 225);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(246, 41);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(77, 180);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 1;
            label1.Text = "Wellcome User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_100;
            pictureBox1.Location = new Point(76, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(297, 35);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(803, 625);
            pnlFormLoader.TabIndex = 2;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1100, 660);
            Controls.Add(pnlFormLoader);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label txtExit;
        private Label label5;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Label label1;
        private Button btnReturnBook;
        private Button btnLoanBook;
        private Button btnMemReg;
        private Button btnBookReg;
        private Button btnInqBook;
        private Panel pnlFormLoader;
        private Button btnLogout;
    }
}
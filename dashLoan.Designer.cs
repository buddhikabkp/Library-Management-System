namespace LibraryManagmentSystem
{
    partial class dashLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashLoan));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtLoanID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpIssueDate = new DateTimePicker();
            label4 = new Label();
            dtpReturnDate = new DateTimePicker();
            label5 = new Label();
            cmbStatus = new ComboBox();
            label7 = new Label();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgLoan = new DataGridView();
            btnDelete = new Button();
            btnIssue = new Button();
            lblClear = new Label();
            cmbBookID = new ComboBox();
            cmbMemberID = new ComboBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgLoan).BeginInit();
            SuspendLayout();
            // 
            // txtLoanID
            // 
            txtLoanID.BorderStyle = BorderStyle.FixedSingle;
            txtLoanID.Location = new Point(138, 36);
            txtLoanID.Name = "txtLoanID";
            txtLoanID.Size = new Size(236, 27);
            txtLoanID.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 42);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 11;
            label1.Text = "Loan ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 86);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 13;
            label2.Text = "Book ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(26, 131);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 15;
            label3.Text = "Member ID";
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.Format = DateTimePickerFormat.Short;
            dtpIssueDate.Location = new Point(541, 35);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(236, 27);
            dtpIssueDate.TabIndex = 18;
            dtpIssueDate.ValueChanged += dtpIssueDate_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(429, 40);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 17;
            label4.Text = "Issue Date";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Format = DateTimePickerFormat.Short;
            dtpReturnDate.Location = new Point(541, 81);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(236, 27);
            dtpReturnDate.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label5.Location = new Point(429, 86);
            label5.Name = "label5";
            label5.Size = new Size(98, 18);
            label5.TabIndex = 19;
            label5.Text = "Return Date";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Return", "Not-Return" });
            cmbStatus.Location = new Point(541, 127);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(236, 28);
            cmbStatus.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label7.Location = new Point(429, 131);
            label7.Name = "label7";
            label7.Size = new Size(56, 18);
            label7.TabIndex = 21;
            label7.Text = "Status";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonHighlight;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(750, 311);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(27, 27);
            btnRefresh.TabIndex = 29;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonHighlight;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(717, 311);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(27, 27);
            btnSearch.TabIndex = 28;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(406, 311);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(305, 27);
            txtSearch.TabIndex = 27;
            txtSearch.Text = "Enter Member ID";
            // 
            // dgLoan
            // 
            dgLoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLoan.BackgroundColor = SystemColors.ButtonHighlight;
            dgLoan.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(182, 149, 222);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgLoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLoan.EnableHeadersVisualStyles = false;
            dgLoan.Location = new Point(26, 360);
            dgLoan.Name = "dgLoan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgLoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgLoan.RowHeadersVisible = false;
            dgLoan.RowHeadersWidth = 51;
            dgLoan.Size = new Size(753, 243);
            dgLoan.TabIndex = 30;
            dgLoan.CellContentClick += dgLoan_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(182, 149, 222);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(619, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 30);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnIssue
            // 
            btnIssue.BackColor = Color.FromArgb(182, 149, 222);
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssue.ForeColor = SystemColors.ButtonHighlight;
            btnIssue.Location = new Point(256, 222);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(158, 30);
            btnIssue.TabIndex = 32;
            btnIssue.Text = "ISSUE";
            btnIssue.UseVisualStyleBackColor = false;
            btnIssue.Click += btnIssue_Click;
            // 
            // lblClear
            // 
            lblClear.AutoSize = true;
            lblClear.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblClear.Location = new Point(26, 228);
            lblClear.Name = "lblClear";
            lblClear.Size = new Size(89, 18);
            lblClear.TabIndex = 31;
            lblClear.Text = "Clear Field";
            lblClear.Click += lblClear_Click;
            // 
            // cmbBookID
            // 
            cmbBookID.FormattingEnabled = true;
            cmbBookID.Items.AddRange(new object[] { "Return", "Not-Return" });
            cmbBookID.Location = new Point(138, 80);
            cmbBookID.Name = "cmbBookID";
            cmbBookID.Size = new Size(236, 28);
            cmbBookID.TabIndex = 35;
            // 
            // cmbMemberID
            // 
            cmbMemberID.FormattingEnabled = true;
            cmbMemberID.Items.AddRange(new object[] { "Return", "Not-Return" });
            cmbMemberID.Location = new Point(138, 121);
            cmbMemberID.Name = "cmbMemberID";
            cmbMemberID.Size = new Size(236, 28);
            cmbMemberID.TabIndex = 36;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(182, 149, 222);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(439, 222);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(158, 30);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dashLoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 230, 254);
            ClientSize = new Size(803, 625);
            Controls.Add(btnUpdate);
            Controls.Add(cmbMemberID);
            Controls.Add(cmbBookID);
            Controls.Add(btnDelete);
            Controls.Add(btnIssue);
            Controls.Add(lblClear);
            Controls.Add(dgLoan);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cmbStatus);
            Controls.Add(label7);
            Controls.Add(dtpReturnDate);
            Controls.Add(label5);
            Controls.Add(dtpIssueDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLoanID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashLoan";
            Text = "dashLoan";
            Load += dashLoan_Load;
            ((System.ComponentModel.ISupportInitialize)dgLoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoanID;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpIssueDate;
        private Label label4;
        private DateTimePicker dtpReturnDate;
        private Label label5;
        private ComboBox cmbStatus;
        private Label label7;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgLoan;
        private Button btnDelete;
        private Button btnIssue;
        private Label lblClear;
        private ComboBox cmbBookID;
        private ComboBox cmbMemberID;
        private Button btnUpdate;
    }
}
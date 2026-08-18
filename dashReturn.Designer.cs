namespace LibraryManagmentSystem
{
    partial class dashReturn
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashReturn));
            cmbLoanID = new ComboBox();
            lblClear = new Label();
            dgReturn = new DataGridView();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label5 = new Label();
            loanID = new Label();
            returnID = new Label();
            txtReturnID = new TextBox();
            dtpReturnDate = new DateTimePicker();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgReturn).BeginInit();
            SuspendLayout();
            // 
            // cmbLoanID
            // 
            cmbLoanID.FormattingEnabled = true;
            cmbLoanID.Location = new Point(140, 114);
            cmbLoanID.Name = "cmbLoanID";
            cmbLoanID.Size = new Size(236, 28);
            cmbLoanID.TabIndex = 55;
            // 
            // lblClear
            // 
            lblClear.AutoSize = true;
            lblClear.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblClear.Location = new Point(428, 124);
            lblClear.Name = "lblClear";
            lblClear.Size = new Size(89, 18);
            lblClear.TabIndex = 52;
            lblClear.Text = "Clear Field";
            lblClear.Click += lblClear_Click;
            // 
            // dgReturn
            // 
            dgReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgReturn.BackgroundColor = SystemColors.ButtonHighlight;
            dgReturn.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(182, 149, 222);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgReturn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReturn.EnableHeadersVisualStyles = false;
            dgReturn.Location = new Point(25, 353);
            dgReturn.Name = "dgReturn";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgReturn.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgReturn.RowHeadersVisible = false;
            dgReturn.RowHeadersWidth = 51;
            dgReturn.Size = new Size(753, 243);
            dgReturn.TabIndex = 51;
            dgReturn.CellContentClick += dgReturn_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonHighlight;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(749, 304);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(27, 27);
            btnRefresh.TabIndex = 50;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonHighlight;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(716, 304);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(27, 27);
            btnSearch.TabIndex = 49;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(405, 304);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(305, 27);
            txtSearch.TabIndex = 48;
            txtSearch.Text = "Enter Member ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label5.Location = new Point(428, 64);
            label5.Name = "label5";
            label5.Size = new Size(98, 18);
            label5.TabIndex = 44;
            label5.Text = "Return Date";
            // 
            // loanID
            // 
            loanID.AutoSize = true;
            loanID.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            loanID.Location = new Point(28, 121);
            loanID.Name = "loanID";
            loanID.Size = new Size(66, 18);
            loanID.TabIndex = 38;
            loanID.Text = "Loan ID";
            // 
            // returnID
            // 
            returnID.AutoSize = true;
            returnID.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            returnID.Location = new Point(28, 67);
            returnID.Name = "returnID";
            returnID.Size = new Size(81, 18);
            returnID.TabIndex = 56;
            returnID.Text = "Return ID";
            // 
            // txtReturnID
            // 
            txtReturnID.Location = new Point(140, 62);
            txtReturnID.Name = "txtReturnID";
            txtReturnID.Size = new Size(236, 27);
            txtReturnID.TabIndex = 57;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Format = DateTimePickerFormat.Short;
            dtpReturnDate.Location = new Point(540, 61);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(236, 27);
            dtpReturnDate.TabIndex = 58;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(182, 149, 222);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = SystemColors.ButtonHighlight;
            btnReturn.Location = new Point(28, 222);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(751, 30);
            btnReturn.TabIndex = 59;
            btnReturn.Text = "RETURN";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // dashReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 230, 254);
            ClientSize = new Size(803, 625);
            Controls.Add(btnReturn);
            Controls.Add(dtpReturnDate);
            Controls.Add(txtReturnID);
            Controls.Add(returnID);
            Controls.Add(cmbLoanID);
            Controls.Add(lblClear);
            Controls.Add(dgReturn);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label5);
            Controls.Add(loanID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashReturn";
            Text = "dashReturn";
            Load += dashReturn_Load;
            ((System.ComponentModel.ISupportInitialize)dgReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbLoanID;
        private Label lblClear;
        private DataGridView dgReturn;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label5;
        private Label loanID;
        private Label returnID;
        private TextBox txtReturnID;
        private DateTimePicker dtpReturnDate;
        private Button btnReturn;
    }
}
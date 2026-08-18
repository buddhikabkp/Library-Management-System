namespace LibraryManagmentSystem
{
    partial class dashBookReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashBookReg));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtBookID = new TextBox();
            label1 = new Label();
            txtBookTitle = new TextBox();
            label2 = new Label();
            txtBookAuthor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtISBN = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbLanguage = new ComboBox();
            cmbAvailability = new ComboBox();
            label7 = new Label();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgBook = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblClear = new Label();
            cmbCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgBook).BeginInit();
            SuspendLayout();
            // 
            // txtBookID
            // 
            txtBookID.BorderStyle = BorderStyle.FixedSingle;
            txtBookID.Location = new Point(138, 36);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(236, 27);
            txtBookID.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 42);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 9;
            label1.Text = "Book ID";
            // 
            // txtBookTitle
            // 
            txtBookTitle.BorderStyle = BorderStyle.FixedSingle;
            txtBookTitle.Location = new Point(138, 78);
            txtBookTitle.Multiline = true;
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(236, 63);
            txtBookTitle.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 84);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 11;
            label2.Text = "Book Title";
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtBookAuthor.Location = new Point(138, 159);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(236, 27);
            txtBookAuthor.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(26, 165);
            label3.Name = "label3";
            label3.Size = new Size(99, 18);
            label3.TabIndex = 13;
            label3.Text = "Book Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(425, 42);
            label4.Name = "label4";
            label4.Size = new Size(80, 18);
            label4.TabIndex = 15;
            label4.Text = "Language";
            // 
            // txtISBN
            // 
            txtISBN.BorderStyle = BorderStyle.FixedSingle;
            txtISBN.Location = new Point(537, 120);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(236, 27);
            txtISBN.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label5.Location = new Point(425, 126);
            label5.Name = "label5";
            label5.Size = new Size(47, 18);
            label5.TabIndex = 17;
            label5.Text = "ISBN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label6.Location = new Point(425, 84);
            label6.Name = "label6";
            label6.Size = new Size(76, 18);
            label6.TabIndex = 19;
            label6.Text = "Category";
            // 
            // cmbLanguage
            // 
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "English", "Sinhala", "Tamil", "French", "Spanish" });
            cmbLanguage.Location = new Point(537, 38);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(236, 28);
            cmbLanguage.TabIndex = 21;
            // 
            // cmbAvailability
            // 
            cmbAvailability.FormattingEnabled = true;
            cmbAvailability.Items.AddRange(new object[] { "Available", "Not-Available" });
            cmbAvailability.Location = new Point(537, 161);
            cmbAvailability.Name = "cmbAvailability";
            cmbAvailability.Size = new Size(236, 28);
            cmbAvailability.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label7.Location = new Point(425, 165);
            label7.Name = "label7";
            label7.Size = new Size(94, 18);
            label7.TabIndex = 22;
            label7.Text = "Availability";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonHighlight;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(746, 321);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(27, 27);
            btnRefresh.TabIndex = 30;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonHighlight;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(713, 321);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(27, 27);
            btnSearch.TabIndex = 29;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(436, 321);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(271, 27);
            txtSearch.TabIndex = 28;
            txtSearch.Text = "Enter Member ID";
            // 
            // dgBook
            // 
            dgBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBook.BackgroundColor = SystemColors.ButtonHighlight;
            dgBook.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(182, 149, 222);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBook.EnableHeadersVisualStyles = false;
            dgBook.Location = new Point(26, 370);
            dgBook.Name = "dgBook";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgBook.RowHeadersWidth = 51;
            dgBook.Size = new Size(747, 227);
            dgBook.TabIndex = 31;
            dgBook.CellContentClick += dgBook_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(182, 149, 222);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(615, 246);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 30);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(182, 149, 222);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(440, 246);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(158, 30);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(182, 149, 222);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(266, 246);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 30);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblClear
            // 
            lblClear.AutoSize = true;
            lblClear.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblClear.Location = new Point(26, 252);
            lblClear.Name = "lblClear";
            lblClear.Size = new Size(89, 18);
            lblClear.TabIndex = 32;
            lblClear.Text = "Clear Field";
            lblClear.Click += lblClear_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Fantasy", "Science Fiction", "Horror", "Biography", "Romance", "Novel", "Graphic novel & Comics", "News Paper & Articles", "Business & Economics", "Science & Technology", "Health & Wellness", "Cookbooks & Food" });
            cmbCategory.Location = new Point(537, 78);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(236, 28);
            cmbCategory.TabIndex = 36;
            // 
            // dashBookReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 230, 254);
            ClientSize = new Size(803, 625);
            Controls.Add(cmbCategory);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblClear);
            Controls.Add(dgBook);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cmbAvailability);
            Controls.Add(label7);
            Controls.Add(cmbLanguage);
            Controls.Add(label6);
            Controls.Add(txtISBN);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBookAuthor);
            Controls.Add(label3);
            Controls.Add(txtBookTitle);
            Controls.Add(label2);
            Controls.Add(txtBookID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashBookReg";
            Text = "dashBookReg";
            Load += dashBookReg_Load;
            ((System.ComponentModel.ISupportInitialize)dgBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBookID;
        private Label label1;
        private TextBox txtBookTitle;
        private Label label2;
        private TextBox txtBookAuthor;
        private Label label3;
        private Label label4;
        private TextBox txtISBN;
        private Label label5;
        private Label label6;
        private ComboBox cmbLanguage;
        private ComboBox cmbAvailability;
        private Label label7;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgBook;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lblClear;
        private ComboBox cmbCategory;
    }
}
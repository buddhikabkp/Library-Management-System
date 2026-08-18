namespace LibraryManagmentSystem
{
    partial class dashMemReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashMemReg));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMemID = new TextBox();
            txtMemName = new TextBox();
            txtNIC = new TextBox();
            txtTelNo = new TextBox();
            txtAddress = new TextBox();
            dtpDOB = new DateTimePicker();
            dtpRegDate = new DateTimePicker();
            cmbProfession = new ComboBox();
            label9 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            dgMember = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgMember).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 0;
            label1.Text = "Member ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.Location = new Point(25, 84);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(25, 125);
            label3.Name = "label3";
            label3.Size = new Size(103, 18);
            label3.TabIndex = 2;
            label3.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(24, 166);
            label4.Name = "label4";
            label4.Size = new Size(37, 18);
            label4.TabIndex = 3;
            label4.Text = "NIC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label5.Location = new Point(401, 43);
            label5.Name = "label5";
            label5.Size = new Size(90, 18);
            label5.TabIndex = 4;
            label5.Text = "Contact No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label6.Location = new Point(401, 84);
            label6.Name = "label6";
            label6.Size = new Size(68, 18);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label7.Location = new Point(401, 125);
            label7.Name = "label7";
            label7.Size = new Size(88, 18);
            label7.TabIndex = 6;
            label7.Text = "Profession";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label8.Location = new Point(400, 166);
            label8.Name = "label8";
            label8.Size = new Size(130, 18);
            label8.TabIndex = 7;
            label8.Text = "Regisrered Date";
            // 
            // txtMemID
            // 
            txtMemID.BorderStyle = BorderStyle.FixedSingle;
            txtMemID.Location = new Point(137, 37);
            txtMemID.Name = "txtMemID";
            txtMemID.Size = new Size(236, 27);
            txtMemID.TabIndex = 8;
            // 
            // txtMemName
            // 
            txtMemName.BorderStyle = BorderStyle.FixedSingle;
            txtMemName.Location = new Point(137, 78);
            txtMemName.Name = "txtMemName";
            txtMemName.Size = new Size(236, 27);
            txtMemName.TabIndex = 9;
            // 
            // txtNIC
            // 
            txtNIC.BorderStyle = BorderStyle.FixedSingle;
            txtNIC.Location = new Point(136, 160);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(236, 27);
            txtNIC.TabIndex = 11;
            // 
            // txtTelNo
            // 
            txtTelNo.BorderStyle = BorderStyle.FixedSingle;
            txtTelNo.Location = new Point(541, 37);
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(236, 27);
            txtTelNo.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(541, 78);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(236, 27);
            txtAddress.TabIndex = 13;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(136, 120);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(237, 27);
            dtpDOB.TabIndex = 15;
            // 
            // dtpRegDate
            // 
            dtpRegDate.Format = DateTimePickerFormat.Short;
            dtpRegDate.Location = new Point(541, 160);
            dtpRegDate.Name = "dtpRegDate";
            dtpRegDate.Size = new Size(237, 27);
            dtpRegDate.TabIndex = 16;
            // 
            // cmbProfession
            // 
            cmbProfession.FormattingEnabled = true;
            cmbProfession.Items.AddRange(new object[] { "Teacher", "Student", "Other" });
            cmbProfession.Location = new Point(542, 119);
            cmbProfession.Name = "cmbProfession";
            cmbProfession.Size = new Size(236, 28);
            cmbProfession.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label9.Location = new Point(27, 236);
            label9.Name = "label9";
            label9.Size = new Size(89, 18);
            label9.TabIndex = 18;
            label9.Text = "Clear Field";
            label9.Click += label9_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(182, 149, 222);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(257, 230);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 30);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(182, 149, 222);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(441, 230);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(158, 30);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(182, 149, 222);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(620, 230);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 30);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(441, 313);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(271, 27);
            txtSearch.TabIndex = 22;
            txtSearch.Text = "Enter Member ID";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonHighlight;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(718, 313);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(27, 27);
            btnSearch.TabIndex = 23;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonHighlight;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(751, 313);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(27, 27);
            btnRefresh.TabIndex = 24;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgMember
            // 
            dgMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMember.BackgroundColor = SystemColors.ButtonHighlight;
            dgMember.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(182, 149, 222);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMember.EnableHeadersVisualStyles = false;
            dgMember.Location = new Point(25, 358);
            dgMember.Name = "dgMember";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgMember.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgMember.RowHeadersVisible = false;
            dgMember.RowHeadersWidth = 51;
            dgMember.Size = new Size(753, 243);
            dgMember.TabIndex = 25;
            dgMember.CellContentClick += dgMember_CellContentClick;
            // 
            // dashMemReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 230, 254);
            ClientSize = new Size(803, 625);
            Controls.Add(dgMember);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label9);
            Controls.Add(cmbProfession);
            Controls.Add(dtpRegDate);
            Controls.Add(dtpDOB);
            Controls.Add(txtAddress);
            Controls.Add(txtTelNo);
            Controls.Add(txtNIC);
            Controls.Add(txtMemName);
            Controls.Add(txtMemID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashMemReg";
            Text = "dashMemReg";
            Load += dashMemReg_Load;
            ((System.ComponentModel.ISupportInitialize)dgMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMemID;
        private TextBox txtMemName;
        private TextBox txtNIC;
        private TextBox txtTelNo;
        private TextBox txtAddress;
        private DateTimePicker dtpDOB;
        private DateTimePicker dtpRegDate;
        private ComboBox cmbProfession;
        private Label label9;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private DataGridView dgMember;
    }
}
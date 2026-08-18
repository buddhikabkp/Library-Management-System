namespace LibraryManagmentSystem
{
    partial class dashSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashSearch));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgBookSearch = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgBookSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonHighlight;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(333, 266);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(27, 27);
            btnRefresh.TabIndex = 27;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonHighlight;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(300, 266);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(27, 27);
            btnSearch.TabIndex = 26;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(23, 266);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(271, 27);
            txtSearch.TabIndex = 25;
            txtSearch.Text = "Enter Book ID";
            // 
            // dgBookSearch
            // 
            dgBookSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBookSearch.BackgroundColor = SystemColors.ButtonHighlight;
            dgBookSearch.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(182, 149, 222);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgBookSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgBookSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBookSearch.EnableHeadersVisualStyles = false;
            dgBookSearch.Location = new Point(23, 312);
            dgBookSearch.Name = "dgBookSearch";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgBookSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgBookSearch.RowHeadersVisible = false;
            dgBookSearch.RowHeadersWidth = 51;
            dgBookSearch.Size = new Size(753, 290);
            dgBookSearch.TabIndex = 28;
            dgBookSearch.CellContentClick += dgBookSearch_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(753, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // dashSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 230, 254);
            ClientSize = new Size(803, 625);
            Controls.Add(pictureBox1);
            Controls.Add(dgBookSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashSearch";
            Text = "dashSearch";
            Load += dashSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgBookSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgBookSearch;
        private PictureBox pictureBox1;
    }
}
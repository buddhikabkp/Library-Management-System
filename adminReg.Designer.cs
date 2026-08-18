namespace LibraryManagmentSystem
{
    partial class adminReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminReg));
            btnShow = new Button();
            btnHide = new Button();
            txtExit = new Label();
            label4 = new Label();
            btnSignUp = new Button();
            btnSignIn = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.BackgroundImage = Properties.Resources.icons8_eye_30;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Location = new Point(714, 325);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(30, 29);
            btnShow.TabIndex = 32;
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.BackgroundImage = Properties.Resources.icons8_invisible_30;
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = FlatStyle.Flat;
            btnHide.Location = new Point(714, 325);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(30, 26);
            btnHide.TabIndex = 31;
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // txtExit
            // 
            txtExit.AutoSize = true;
            txtExit.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExit.Location = new Point(749, 9);
            txtExit.Name = "txtExit";
            txtExit.Size = new Size(20, 22);
            txtExit.TabIndex = 30;
            txtExit.Text = "X";
            txtExit.Click += txtExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(367, 444);
            label4.Name = "label4";
            label4.Size = new Size(132, 18);
            label4.TabIndex = 29;
            label4.Text = "Login your Account";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(182, 149, 222);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(367, 381);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(382, 38);
            btnSignUp.TabIndex = 28;
            btnSignUp.Text = "Register";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(182, 149, 222);
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = SystemColors.ButtonHighlight;
            btnSignIn.Location = new Point(367, 465);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(382, 38);
            btnSignIn.TabIndex = 27;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(367, 321);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(382, 34);
            txtPassword.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(367, 297);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 25;
            label3.Text = "Password :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(367, 184);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(382, 34);
            txtUserName.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(367, 160);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 23;
            label2.Text = "User Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 71);
            label1.Name = "label1";
            label1.Size = new Size(271, 34);
            label1.TabIndex = 22;
            label1.Text = "Register Account";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(211, 187, 237);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 529);
            panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 313);
            label5.Name = "label5";
            label5.Size = new Size(316, 27);
            label5.TabIndex = 0;
            label5.Text = "Library Managment System";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(367, 252);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(382, 34);
            txtEmail.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(367, 228);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 33;
            label6.Text = "Email :";
            // 
            // adminReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(781, 529);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(btnSignIn);
            Controls.Add(label4);
            Controls.Add(btnShow);
            Controls.Add(btnHide);
            Controls.Add(txtExit);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminReg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminReg";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShow;
        private Button btnHide;
        private Label txtExit;
        private Label label4;
        private Button btnSignUp;
        private Button btnSignIn;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUserName;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
    }
}
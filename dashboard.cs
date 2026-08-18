using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentSystem
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();

            this.pnlFormLoader.Controls.Clear();
            dashPan dashboard_vrb = new dashPan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard_vrb);
            dashboard_vrb.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            dashPan dashboard_vrb = new dashPan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard_vrb);
            dashboard_vrb.Show();
        }

        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            dashLoan dashboard_vrb = new dashLoan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard_vrb);
            dashboard_vrb.Show();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            dashReturn dashboard_vrb = new dashReturn() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard_vrb);
            dashboard_vrb.Show();
        }

        private void btnInqBook_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            dashSearch dashboard_vrb = new dashSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard_vrb);
            dashboard_vrb.Show();
        }

        private void btnBookReg_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            dashBookReg dashboard_vrb = new dashBookReg() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard_vrb);
            dashboard_vrb.Show();
        }

        private void btnMemReg_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            dashMemReg dashboard_vrb = new dashMemReg() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard_vrb);
            dashboard_vrb.Show();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Close This Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Logout", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login back = new Login();
                back.Show();
            }
        }
    }
}

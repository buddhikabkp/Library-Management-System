using Microsoft.Data.SqlClient;
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
    public partial class dashPan : Form
    {
        public dashPan()
        {
            InitializeComponent();
        }

        private void dashPan_Load(object sender, EventArgs e)
        {
            DisplayMemberCount();
            DisplayBookCount();
            DisplayIssuedBookCount();
        }

        private void DisplayMemberCount()
        {
            using (SqlConnection con = new DBConnection().getDBConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Member", con);
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                txtMemCount.Text = count.ToString();
            }
        }

        private void DisplayBookCount()
        {
            using (SqlConnection con = new DBConnection().getDBConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Book", con);
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                txtBookCount.Text = count.ToString();
            }
        }

        private void DisplayIssuedBookCount()
        {
            using (SqlConnection con = new DBConnection().getDBConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Loan WHERE Status = 'Not-Return'", con);
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                txtIssuedBookCount.Text = count.ToString();
            }
        }
    }
}

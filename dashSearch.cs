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
    public partial class dashSearch : Form
    {
        SqlConnection con = new DBConnection().getDBConnection();

        bool isDialogOpen = false;

        public dashSearch()
        {
            InitializeComponent();
        }

        private void dashSearch_Load(object sender, EventArgs e)
        {
            displayGrid();
        }

        private void displayGrid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Book_ID, BookTitle, BookAuthor, Language, Category, ISBN, Availability FROM Book", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgBookSearch.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Book :" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please Enter Valid ID");
                return;
            }

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Book WHERE Book_ID = @Book_ID", con))
                {
                    command.Parameters.AddWithValue("Book_ID", txtSearch.Text.Trim());

                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    dgBookSearch.DataSource = dt;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Book", con))
                {
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    dgBookSearch.DataSource = dt;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        private void dgBookSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !isDialogOpen)
            {
                isDialogOpen = true;
                DataGridViewRow row = dgBookSearch.Rows[e.RowIndex];

                SearchBookInfo bookInfo = new SearchBookInfo();

                bookInfo.SetBookData(
                    row.Cells["Book_ID"].Value?.ToString(),
                    row.Cells["BookTitle"].Value?.ToString(),
                    row.Cells["BookAuthor"].Value?.ToString(),
                    row.Cells["Language"].Value?.ToString(),
                    row.Cells["Category"].Value?.ToString(),
                    row.Cells["ISBN"].Value?.ToString(),
                    row.Cells["Availability"].Value?.ToString()
                );

                bookInfo.FormClosed += (s, args) => { isDialogOpen = false; };
                bookInfo.ShowDialog();
            }
        }
    }
}

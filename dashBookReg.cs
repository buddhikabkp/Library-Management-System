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
    public partial class dashBookReg : Form
    {
        SqlConnection con = new DBConnection().getDBConnection();

        public dashBookReg()
        {
            InitializeComponent();
        }

        private void dashBookReg_Load(object sender, EventArgs e)
        {
            generateBook_ID();
            displayGrid();
        }

        private void generateBook_ID()
        {
            string currentID = "B0000";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT top 1 Book_ID FROM Book ORDER BY Book_ID Desc", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                currentID = reader["Book_ID"].ToString();
            }

            int nextIDNo = Convert.ToInt32(currentID.Substring(1)) + 1;
            string nextID = "B" + nextIDNo.ToString("D4");
            con.Close();

            txtBookID.Text = nextID;

        }

        private void displayGrid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Book_ID, BookTitle, BookAuthor, Language, Category, ISBN , Availability FROM Book", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgBook.DataSource = dt;
            con.Close();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtBookID.Clear();
            txtBookTitle.Clear();
            txtBookAuthor.Clear();
            cmbLanguage.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            txtISBN.Clear();
            cmbAvailability.SelectedIndex = -1;

        }

        private void dgBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgBook.Rows[e.RowIndex];

                //Display datas in text fields from the selected row

                txtBookID.Text = dgvRow.Cells[0].Value?.ToString() ?? string.Empty;
                txtBookTitle.Text = dgvRow.Cells[1].Value?.ToString() ?? string.Empty;
                txtBookAuthor.Text = dgvRow.Cells[2].Value?.ToString() ?? string.Empty;

                //For cmbLanguage

                string LanguageValue = dgvRow.Cells[3].Value?.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(LanguageValue))
                {
                    cmbLanguage.SelectedItem = LanguageValue;
                    if (cmbLanguage.SelectedItem == null)
                    {
                        int index = cmbLanguage.FindStringExact(LanguageValue);
                        if (index != -1)
                        {
                            cmbLanguage.SelectedIndex = index;
                        }
                    }
                }

                //For Category

                string CategoryValue = dgvRow.Cells[4].Value?.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(CategoryValue))
                {
                    cmbCategory.SelectedItem = CategoryValue;
                    if (cmbCategory.SelectedItem == null)
                    {
                        int index = cmbCategory.FindStringExact(CategoryValue);
                        if (index != -1)
                        {
                            cmbCategory.SelectedIndex = index;
                        }
                    }
                }

                //For ISBN
                txtISBN.Text = dgvRow.Cells[5].Value?.ToString() ?? string.Empty;

                //For Availability

                string AvailabilityValue = dgvRow.Cells[6].Value?.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(AvailabilityValue))
                {
                    cmbAvailability.SelectedItem = AvailabilityValue;
                    if (cmbAvailability.SelectedItem == null)
                    {
                        int index = cmbAvailability.FindStringExact(AvailabilityValue);
                        if (index != -1)
                        {
                            cmbAvailability.SelectedIndex = index;
                        }
                    }
                }

            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtBookTitle.Text) ||
                string.IsNullOrWhiteSpace(txtBookAuthor.Text) ||
                cmbLanguage.SelectedItem == null ||
                cmbCategory.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtISBN.Text) ||
                cmbAvailability.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            RegBook RegBook = new RegBook();
            RegBook.Book_ID = txtBookID.Text;
            RegBook.BookTitle = txtBookTitle.Text;
            RegBook.BookAuthor = txtBookAuthor.Text;
            RegBook.Language = cmbLanguage.SelectedItem.ToString();
            RegBook.Category = cmbCategory.SelectedItem.ToString();
            RegBook.ISBN = txtISBN.Text;
            RegBook.Availability = cmbAvailability.SelectedItem.ToString();
            RegBook.Register();
            displayGrid();
            MessageBox.Show("Book Added Successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RegBook RegBook = new RegBook();
            RegBook.Book_ID = txtBookID.Text;
            RegBook.BookTitle = txtBookTitle.Text;
            RegBook.BookAuthor = txtBookAuthor.Text;
            RegBook.Language = cmbLanguage.SelectedItem.ToString();
            RegBook.Category = cmbCategory.SelectedItem.ToString();
            RegBook.ISBN = txtISBN.Text;
            RegBook.Availability = cmbAvailability.SelectedItem.ToString();
            RegBook.Update();
            displayGrid();
            MessageBox.Show("Book Updated Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookID.Text))
            {
                MessageBox.Show("Please Enter the Book ID to Delete");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Delete This Book ?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    RegBook RegBook = new RegBook();
                    RegBook.Book_ID = txtBookID.Text;
                    RegBook.Delete();
                    displayGrid();
                    MessageBox.Show("Book Deleted Successfully");
                    Clearform();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Foreign key constraint violation
                    {
                        MessageBox.Show("This book cannot be deleted because it is currently borrowed by a member.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"An error occurred while deleting the book: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Clearform()
        {
            txtBookID.Clear();
            txtBookTitle.Clear();
            txtBookAuthor.Clear();

            cmbLanguage.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;

            txtISBN.Clear();
            cmbAvailability.SelectedIndex = -1;

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

                    dgBook.DataSource = dt;
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

                    dgBook.DataSource = dt;
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
    }
}

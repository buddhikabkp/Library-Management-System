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
    public partial class dashLoan : Form
    {
        SqlConnection con = new DBConnection().getDBConnection();

        public dashLoan()
        {
            InitializeComponent();

            //Attach the event handler to the issue date dataTimePicker
            dtpIssueDate.ValueChanged += new EventHandler(dtpIssueDate_ValueChanged);

            //Set initial value for dtpIssueDate
            dtpIssueDate.Value = DateTime.Now;

            //Set the return fate automatically 
            dtpReturnDate.Value = dtpIssueDate.Value.AddDays(30);
        }

        private void dashLoan_Load(object sender, EventArgs e)
        {
            generateLoan_ID();
            displayLoanGrid();
            fillComboSearchMember();
            fillComboSearchBook();
        }

        private void generateLoan_ID()
        {
            string currentID = "L0000";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT top 1 Loan_ID FROM Loan ORDER BY Loan_ID Desc", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                currentID = reader["Loan_ID"].ToString();
            }

            int nextIDNo = Convert.ToInt32(currentID.Substring(1)) + 1;
            string nextID = "L" + nextIDNo.ToString("D4");
            con.Close();

            txtLoanID.Text = nextID;
        }

        private void displayLoanGrid()
        {
            //con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Loan_ID, Book_ID, Member_ID, Issue_Date, Return_Date, Status FROM Loan", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgLoan.DataSource = dt;
            con.Close();
        }

        private void fillComboSearchMember()
        {
            cmbMemberID.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Member_ID FROM Member";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbMemberID.Items.Add(dr["Member_ID"].ToString());
            }

            con.Close();
        }

        private void fillComboSearchBook()
        {
            cmbBookID.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Book_ID FROM Book";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbBookID.Items.Add(dr["Book_ID"].ToString());
            }

            con.Close();
        }

        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            //Automatically add 30 days to the issue date and set as the return date
            dtpReturnDate.Value = dtpIssueDate.Value.AddDays(30);
        }

        private void dgLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgLoan.Rows[e.RowIndex];

                //Populate textField
                txtLoanID.Text = dgvRow.Cells[0].Value?.ToString() ?? string.Empty;

                //Populate combobox BookID
                string BookIDValue = dgvRow.Cells[1].Value?.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(BookIDValue))
                {
                    cmbBookID.SelectedItem = BookIDValue;
                    if (cmbBookID.SelectedItem == null)
                    {
                        int index = cmbBookID.FindStringExact(BookIDValue);
                        if (index != -1)
                        {
                            cmbBookID.SelectedIndex = index;
                        }
                    }
                }

                //Populate combobox MemberId
                string MemberIDValue = dgvRow.Cells[2].Value?.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(MemberIDValue))
                {
                    cmbMemberID.SelectedItem = MemberIDValue;
                    if (cmbMemberID.SelectedItem == null)
                    {
                        int index = cmbMemberID.FindStringExact(MemberIDValue);
                        if (index != -1)
                        {
                            cmbMemberID.SelectedIndex = index;
                        }
                    }
                }

                dtpIssueDate.Value = Convert.ToDateTime(dgvRow.Cells[3].Value ?? DateTime.Now);
                dtpReturnDate.Value = Convert.ToDateTime(dgvRow.Cells[4].Value ?? DateTime.Now);

                string StatusValue = dgvRow.Cells[5].Value?.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(StatusValue))
                {
                    cmbStatus.SelectedItem = StatusValue;
                    if (cmbStatus.SelectedItem == null)
                    {
                        int index = cmbStatus.FindStringExact(StatusValue);
                        if (index != -1)
                        {
                            cmbStatus.SelectedIndex = index;
                        }
                    }
                }
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (cmbBookID.SelectedItem == null || cmbMemberID.SelectedItem == null)
            {
                MessageBox.Show("Please select both Book ID and Member ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bookID = cmbBookID.SelectedItem.ToString();
            string memberID = cmbMemberID.SelectedItem.ToString();

            try
            {
                con.Open();

                //Check book availability
                SqlCommand checkCmd = new SqlCommand("SELECT Availability FROM Book WHERE Book_ID = @BookID", con);
                checkCmd.Parameters.AddWithValue("@BookID", bookID);
                string availability = checkCmd.ExecuteScalar()?.ToString();

                if (availability == null)
                {
                    MessageBox.Show("Book not found in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (availability == "Not-Available")
                {
                    MessageBox.Show("This Book is Currently Not Available. Cannot be borrowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Loan loan = new Loan();
                loan.Loan_ID = txtLoanID.Text;
                loan.Book_ID = bookID;
                loan.Member_ID = memberID;
                loan.Issue_Date = dtpIssueDate.Value.Date.ToString();
                loan.Return_Date = dtpReturnDate.Value.Date.ToString();
                loan.Status = "Not-Return";
                loan.LoanAdd();

                //Update Book availability to "Not-Available"
                SqlCommand updateBookCmd = new SqlCommand("UPDATE Book SET Availability = 'Not-Available' WHERE Book_ID = @BookID", con);
                updateBookCmd.Parameters.AddWithValue("@BookID", bookID);
                updateBookCmd.ExecuteNonQuery();


                displayLoanGrid();
                generateLoan_ID();

                MessageBox.Show("The Book has been issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while issuing the book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "UPDATE Loan SET Book_ID=@Book_ID, Member_ID=@Member_ID, Issue_Date=@Issue_Date, " +
                "Return_Date=@Return_Date, Status=@Status WHERE Loan_ID=@Loan_ID", con);

            cmd.Parameters.AddWithValue("@Loan_ID", txtLoanID.Text.Trim());
            cmd.Parameters.AddWithValue("@Book_ID", cmbBookID.SelectedItem?.ToString() ?? "");
            cmd.Parameters.AddWithValue("@Member_ID", cmbMemberID.SelectedItem?.ToString() ?? "");
            cmd.Parameters.AddWithValue("@Issue_Date", dtpIssueDate.Value);
            cmd.Parameters.AddWithValue("@Return_Date", dtpReturnDate.Value);
            cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem?.ToString() ?? "");

            cmd.ExecuteNonQuery();
            MessageBox.Show("Loan record updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayLoanGrid();

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoanID.Text))
            {
                MessageBox.Show("Please Select the Loan ID to Delete");
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Loan WHERE Loan_ID=@Loan_ID", con);
            cmd.Parameters.AddWithValue("@Loan_ID", txtLoanID.Text.Trim());
            cmd.ExecuteNonQuery();

            MessageBox.Show("Loan record deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayLoanGrid();


            con.Close();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtLoanID.Clear();
            cmbBookID.SelectedIndex = -1;
            cmbMemberID.SelectedIndex = -1;
            dtpIssueDate.Value = DateTime.Now;
            dtpReturnDate.Value = DateTime.Now;
            cmbStatus.SelectedIndex = -1;
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
                using (SqlCommand command = new SqlCommand("SELECT * FROM Loan WHERE Loan_ID = @Loan_ID", con))
                {
                    command.Parameters.AddWithValue("Loan_ID", txtSearch.Text.Trim());

                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    dgLoan.DataSource = dt;
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
                using (SqlCommand command = new SqlCommand("SELECT * FROM Loan", con))
                {
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    dgLoan.DataSource = dt;
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

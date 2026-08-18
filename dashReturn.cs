using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentSystem
{
    public partial class dashReturn : Form
    {
        SqlConnection con = new DBConnection().getDBConnection();
        public dashReturn()
        {
            InitializeComponent();
        }

        private void dashReturn_Load(object sender, EventArgs e)
        {
            generateReturn_ID();
            displayReturnGrid();
            fillComboSearchLoan();

        }

        private void generateReturn_ID()
        {
            string currentID = "R0000";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT top 1 Return_ID FROM [Return] ORDER BY Return_ID Desc", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                currentID = reader["Return_ID"].ToString();
            }

            int nextIDNo = Convert.ToInt32(currentID.Substring(1)) + 1;
            string nextID = "R" + nextIDNo.ToString("D4");
            con.Close();

            txtReturnID.Text = nextID;
        }

        private void displayReturnGrid()
        {
            //con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Return_ID, Loan_ID, Return_Date FROM [Return]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgReturn.DataSource = dt;
            con.Close();
        }

        private void fillComboSearchLoan()
        {
            cmbLoanID.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Loan_ID FROM Loan";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbLoanID.Items.Add(dr["Loan_ID"].ToString());
            }

            con.Close();
        }

        private void dgReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgReturn.Rows[e.RowIndex];

                //Populate textField
                txtReturnID.Text = dgvRow.Cells[0].Value?.ToString() ?? string.Empty;

                //Populate combobox LoanID
                string LoanIDValue = dgvRow.Cells[1].Value?.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(LoanIDValue))
                {
                    cmbLoanID.SelectedItem = LoanIDValue;
                    if (cmbLoanID.SelectedItem == null)
                    {
                        int index = cmbLoanID.FindStringExact(LoanIDValue);
                        if (index != -1)
                        {
                            cmbLoanID.SelectedIndex = index;
                        }
                    }
                }

                //Populate ReturnDate field
                dtpReturnDate.Value = Convert.ToDateTime(dgvRow.Cells[2].Value ?? DateTime.Now);


            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\WW\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (cmbLoanID.SelectedItem == null)
            {
                MessageBox.Show("Please select a Loan ID first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loanID = cmbLoanID.SelectedItem.ToString();
            string returnID = txtReturnID.Text.Trim();
            DateTime returnDate = dtpReturnDate.Value.Date;

            try
            {
                con.Open();

                //Find the Book_ID for this Loan_ID
                string bookID = "";
                SqlCommand getBookCmd = new SqlCommand("SELECT Book_ID FROM Loan WHERE Loan_ID = @LoanID", con);
                getBookCmd.Parameters.AddWithValue("@LoanID", loanID);
                object result = getBookCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("No book found for the selected Loan ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bookID = result.ToString();

                //Update Book availability
                SqlCommand updateBookCmd = new SqlCommand("UPDATE Book SET Availability = 'Available' WHERE Book_ID = @BookID", con);
                updateBookCmd.Parameters.AddWithValue("@BookID", bookID);
                updateBookCmd.ExecuteNonQuery();

                //Update Loan table status
                SqlCommand updateLoanCmd = new SqlCommand("UPDATE Loan SET Status = 'Return' WHERE Loan_ID = @LoanID", con);
                updateLoanCmd.Parameters.AddWithValue("@LoanID", loanID);
                updateLoanCmd.ExecuteNonQuery();

                //Add the return record
                Return returnObj = new Return();
                returnObj.Return_ID = returnID;
                returnObj.Loan_ID = loanID;
                returnObj.Return_Date = returnDate;
                returnObj.ReturnAdd();


                displayReturnGrid();
                MessageBox.Show("The book was returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                generateReturn_ID();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while returning book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtReturnID.Clear();
            cmbLoanID.SelectedIndex = -1;
            dtpReturnDate.Value = DateTime.Now;
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
                using (SqlCommand command = new SqlCommand("SELECT * FROM [Return] WHERE Return_ID = @Return_ID", con))
                {
                    command.Parameters.AddWithValue("Return_ID", txtSearch.Text.Trim());

                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    dgReturn.DataSource = dt;
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
                using (SqlCommand command = new SqlCommand("SELECT * FROM [Return]", con))
                {
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    dgReturn.DataSource = dt;
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

            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }
    }
}

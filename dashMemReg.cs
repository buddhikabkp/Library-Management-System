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
    public partial class dashMemReg : Form
    {
        SqlConnection con = new DBConnection().getDBConnection();

        public dashMemReg()
        {
            InitializeComponent();
        }

        private void dashMemReg_Load(object sender, EventArgs e)
        {
            generateMember_ID();
            displayGrid();
        }

        private void generateMember_ID()
        {
            string currentID = "M0000";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT top 1 Member_ID FROM Member ORDER BY Member_ID Desc", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                currentID = reader["Member_ID"].ToString();
            }

            int nextIDNo = Convert.ToInt32(currentID.Substring(1)) + 1;
            string nextID = "M" + nextIDNo.ToString("D4");
            con.Close();

            txtMemID.Text = nextID;
        }

        private void displayGrid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Member_ID, Name, DOB, NIC, Tel_No, Address, Profession, Reg_Date FROM Member", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgMember.DataSource = dt;
            con.Close();
        }

        //Check if all fields are filled
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtMemName.Text) ||
                string.IsNullOrWhiteSpace(txtNIC.Text) ||
                string.IsNullOrWhiteSpace(txtTelNo.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                cmbProfession.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Validate contact number contains only numbers
            if (!IsValidContactNumber(txtTelNo.Text))
            {
                MessageBox.Show("Please enter valid contact number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelNo.Focus();
                return false;
            }
            return true;
        }

        //validate contact number contains only numbers
        private bool IsValidContactNumber(string contactNumber)
        {
            // Remove any whitespace
            string cleanedNumber = contactNumber.Replace(" ", "").Replace("-", "");

            // Check if the string contains only digits
            return !string.IsNullOrWhiteSpace(cleanedNumber) &&
                   cleanedNumber.All(char.IsDigit);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            Member Member = new Member();
            Member.Member_ID = txtMemID.Text;
            Member.Name = txtMemName.Text;
            Member.DOB = dtpDOB.Value.Date.ToString();
            Member.NIC = txtNIC.Text;
            Member.Tel_No = txtTelNo.Text;
            Member.Address = txtAddress.Text;
            Member.Profession = cmbProfession.SelectedItem.ToString();
            Member.Reg_Date = dtpRegDate.Value.Date.ToString();
            Member.Register();
            displayGrid();
            MessageBox.Show("Member Added Successfully");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Member Member = new Member();
            Member.Member_ID = txtMemID.Text;
            Member.Name = txtMemName.Text;
            Member.DOB = dtpDOB.Value.Date.ToString();
            Member.NIC = txtNIC.Text;
            Member.Tel_No = txtTelNo.Text;
            Member.Address = txtAddress.Text;
            Member.Profession = cmbProfession.SelectedItem.ToString();
            Member.Reg_Date = dtpRegDate.Value.Date.ToString();
            Member.Update();
            displayGrid();
            MessageBox.Show("Member Updated Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemID.Text))
            {
                MessageBox.Show("Please Enter the Member ID to Delete");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Delete This Memeber ?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Member Member = new Member();
                    Member.Member_ID = txtMemID.Text;
                    Member.Delete();
                    displayGrid();
                    MessageBox.Show("Member Deleted Successfully");
                    Clearform();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Foreign key constraint violation
                    {
                        MessageBox.Show("This member cannot be deleted because they have borrowed books that are not yet returned.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"An error occurred while deleting the member: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtMemID.Clear();
            txtMemName.Clear();
            dtpDOB.Value = DateTime.Now;
            txtNIC.Clear();
            txtTelNo.Clear();
            txtAddress.Clear();
            cmbProfession.SelectedIndex = -1;
            dtpRegDate.Value = DateTime.Now;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            txtMemID.Clear();
            txtMemName.Clear();
            dtpDOB.ResetText();
            txtNIC.Clear();
            txtTelNo.Clear();
            txtAddress.Clear();
            cmbProfession.ResetText();
            dtpRegDate.ResetText();
            txtMemID.Focus();
        }

        private void dgMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgMember.Rows[e.RowIndex];

                txtMemID.Text = dgvRow.Cells[0].Value?.ToString() ?? string.Empty;
                txtMemName.Text = dgvRow.Cells[1].Value?.ToString() ?? string.Empty;
                dtpDOB.Value = Convert.ToDateTime(dgvRow.Cells[2].Value ?? DateTime.Now);
                txtNIC.Text = dgvRow.Cells[3].Value?.ToString() ?? string.Empty;
                txtTelNo.Text = dgvRow.Cells[4].Value?.ToString() ?? string.Empty;
                txtAddress.Text = dgvRow.Cells[5].Value?.ToString() ?? string.Empty;

                //filling cmbProfession
                string professionValue = dgvRow.Cells[6].Value?.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(professionValue))
                {
                    cmbProfession.SelectedItem = professionValue;
                    if (cmbProfession.SelectedItem == null)
                    {
                        int index = cmbProfession.FindStringExact(professionValue);
                        if (index != -1)
                        {
                            cmbProfession.SelectedIndex = index;
                        }
                    }
                }
                else
                {
                    if (int.TryParse(professionValue, out int SelectedIndex))
                    {
                        if (SelectedIndex >= 0 && SelectedIndex < cmbProfession.Items.Count)
                        {
                            cmbProfession.SelectedIndex = SelectedIndex;
                        }
                    }
                }

                dtpRegDate.Value = Convert.ToDateTime(dgvRow.Cells[7].Value ?? DateTime.Now);
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
                using (SqlCommand command = new SqlCommand("SELECT * FROM Member WHERE Member_ID = @Member_ID", con))
                {
                    command.Parameters.AddWithValue("Member_ID", txtSearch.Text.Trim());

                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    dgMember.DataSource = dt;
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
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Member", con))
                {
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    dgMember.DataSource = dt;
                }
            }

            catch(Exception ex)
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

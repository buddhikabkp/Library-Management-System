using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace LibraryManagmentSystem
{
    public partial class adminReg : Form
    {

        public adminReg()
        {
            InitializeComponent();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                //Email validation
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private bool CheckIfUsernameExists(string username)
        {
            DBConnection dbConnection = new DBConnection();
            string query = "SELECT COUNT(1) FROM [admin] WHERE UserName = @UserName";

            try
            {
                using (SqlConnection connection = dbConnection.getDBConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", username);
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private bool CheckIfEmailExists(string email)
        {
            DBConnection dbConnection = new DBConnection();
            string query = "SELECT COUNT(1) FROM [admin] WHERE Email = @Email";

            try
            {
                using (SqlConnection connection = dbConnection.getDBConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking email: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; 
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password))

            {
                MessageBox.Show("Please Fill In All The Fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email validation
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if username already exists
            if (CheckIfUsernameExists(username))
            {
                MessageBox.Show("This username has already been taken. Please choose a different username.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                txtUserName.SelectAll();
                return;
            }

            // Check if email already exists
            if (CheckIfEmailExists(email))
            {
                MessageBox.Show("This email is already registered. Please use a different email address.", "Email Registered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }

            //Hashed password 
            string hashedPassword = HashPassword(password);

            DBConnection dbConnection = new DBConnection();
            string query = "INSERT INTO [admin] (Username, Email, Password) VALUES (@Username, @Email, @Password)";

            try
            {
                using (SqlConnection connection = dbConnection.getDBConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("User Registered Successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clearform();
                            Login nLogin = new Login();
                            nLogin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Registration Failed, Please try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("This email is already registered. Please use different email and try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An error accured with the database :" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void Clearform()
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }
    }
}

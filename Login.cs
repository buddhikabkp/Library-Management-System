using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace LibraryManagmentSystem
{
    public partial class Login : Form
    {
        public Login()
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            adminReg adminReg = new adminReg();
            adminReg.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBConnection db = new DBConnection();
                SqlConnection con = db.getDBConnection();

                string enteredUsername = txtUserName.Text.Trim();
                string enteredPassword = txtPassword.Text;

                string hashedPassword = HashPassword(enteredPassword);

                string query = "SELECT * FROM [admin] WHERE Username = @username AND Password = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", enteredUsername);
                    cmd.Parameters.AddWithValue("@password", enteredPassword);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            dashboard adminDash = new dashboard();
                            adminDash.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password. ");
                            txtUserName.Clear();
                            txtPassword.Clear();
                            txtUserName.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error :" + ex.Message);
                    }
                    finally { con.Close(); }
                }
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
    }
}

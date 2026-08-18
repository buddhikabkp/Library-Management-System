using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal class Loan
    {
        SqlConnection con = new DBConnection().getDBConnection();

        public string Loan_ID { get; set; }
        public string Book_ID { get; set; }
        public string Member_ID { get; set; }
        public string Issue_Date { get; set; }
        public string Return_Date { get; set; }
        public string Status { get; set; }

        public void LoanAdd()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Loan VALUES(@Loan_ID, @Book_ID, @Member_ID, @Issue_Date, @Return_Date, @Status)", con);
            cmd.Parameters.AddWithValue("@Loan_ID", Loan_ID);
            cmd.Parameters.AddWithValue("@Book_ID", Book_ID);
            cmd.Parameters.AddWithValue("@Member_ID", Member_ID);
            cmd.Parameters.AddWithValue("@Issue_Date", Issue_Date);
            cmd.Parameters.AddWithValue("@Return_Date", Return_Date);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Update()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Loan SET Book_ID = @Book_ID, Member_ID = @Member_ID, Issue_Date = @Issue_Date, Return_Date = @Return_Date, Status = @Status WHERE Loan_ID = @Loan_ID", con);
            cmd.Parameters.AddWithValue("@Loan_ID", Loan_ID);
            cmd.Parameters.AddWithValue("@Book_ID", Book_ID);
            cmd.Parameters.AddWithValue("@Member_ID", Member_ID);
            cmd.Parameters.AddWithValue("@Issue_Date", Issue_Date);
            cmd.Parameters.AddWithValue("@Return_Date", Return_Date);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE From Loan WHERE Loan_ID = @Loan_ID",con);
            cmd.Parameters.AddWithValue("@Loan_ID", Loan_ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

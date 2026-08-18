using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal class Return
    {
        SqlConnection con = new DBConnection().getDBConnection();

        public string Return_ID { get; set; }
        public string Loan_ID { get; set; }
        public DateTime Return_Date { get; set; }

        
        public void ReturnAdd()
        {
            using (SqlConnection con = new DBConnection().getDBConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Return] (Return_ID, Loan_ID, Return_Date) VALUES (@Return_ID, @Loan_ID, @Return_Date)", con);
                cmd.Parameters.AddWithValue("@Return_ID", Return_ID);
                cmd.Parameters.AddWithValue("@Loan_ID", Loan_ID);
                cmd.Parameters.AddWithValue("@Return_Date", Return_Date);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

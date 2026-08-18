using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal class RegBook
    {
        SqlConnection con = new DBConnection().getDBConnection();

        public string Book_ID { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public string Availability { get; set; }

        public void Register()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Book VALUES(@Book_ID, @BookTitle, @BookAuthor, @ISBN, @Category, @Language, @Availability)", con);
            cmd.Parameters.AddWithValue("@Book_ID", Book_ID);
            cmd.Parameters.AddWithValue("@BookTitle", BookTitle);
            cmd.Parameters.AddWithValue("@BookAuthor", BookAuthor);
            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            cmd.Parameters.AddWithValue("@Category", Category);
            cmd.Parameters.AddWithValue("@Language", Language);
            cmd.Parameters.AddWithValue("@Availability", Availability);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Update()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Book SET BookTitle = @BookTitle, BookAuthor = @BookAuthor, ISBN = @ISBN, Category = @Category, Language = @Language, Availability = @Availability WHERE @Book_ID = Book_ID", con);
            cmd.Parameters.AddWithValue("@Book_ID", Book_ID);
            cmd.Parameters.AddWithValue("@BookTitle", BookTitle);
            cmd.Parameters.AddWithValue("@BookAuthor", BookAuthor);
            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            cmd.Parameters.AddWithValue("@Category", Category);
            cmd.Parameters.AddWithValue("@Language", Language);
            cmd.Parameters.AddWithValue("@Availability", Availability);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Book WHERE Book_ID = @Book_ID", con);
            cmd.Parameters.AddWithValue("@Book_ID", Book_ID);
            cmd.ExecuteNonQuery();
            con.Close() ;
        }


    }
}

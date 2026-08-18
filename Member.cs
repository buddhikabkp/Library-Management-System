using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal class Member
    {
       SqlConnection con = new DBConnection().getDBConnection();

        public string Member_ID { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string NIC { get; set; }
        public string Tel_No { get; set; }
        public string Address { get;set; }
        public string Profession { get; set; }
        public string Reg_Date { get; set; }

        public void Register()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Member VALUES (@Member_ID, @Name, @DOB, @NIC, @Tel_No, @Address, @Profession, @Reg_Date)", con);
            cmd.Parameters.AddWithValue("@Member_ID", Member_ID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@NIC", NIC);
            cmd.Parameters.AddWithValue("@Tel_No", Tel_No);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Profession", Profession);
            cmd.Parameters.AddWithValue("@Reg_Date", Reg_Date);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Update()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Member SET Name = @Name, DOB = @DOB, NIC = @NIC, Tel_No = @Tel_No, Address = @Address, Profession = @Profession, Reg_Date = @Reg_Date WHERE @Member_ID = Member_ID", con);
            cmd.Parameters.AddWithValue("@Member_ID", Member_ID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@NIC", NIC);
            cmd.Parameters.AddWithValue("@Tel_No", Tel_No);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Profession", Profession);
            cmd.Parameters.AddWithValue("@Reg_Date", Reg_Date);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Member WHERE Member_ID = @Member_ID", con);
            cmd.Parameters.AddWithValue("@Member_ID" , Member_ID);
            cmd.ExecuteNonQuery ();
            con.Close();
        }
    }
}

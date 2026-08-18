using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace LibraryManagmentSystem
{
    internal class DBConnection
    {
        public SqlConnection getDBConnection()
        {
            return new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\WW\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}

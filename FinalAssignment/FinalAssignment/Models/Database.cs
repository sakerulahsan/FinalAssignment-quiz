using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.Models
{
    public class Database
    {
        public Books Books { get; set; }

        public Database()
        {
            string connString = "Server=DESKTOP-UB7L7EN\\SQLEXPRESS;Integrated Security=true;Database=Sample_db";
          
            SqlConnection conn = new SqlConnection(connString);
            Books = new Books(conn);
        }
    }
}

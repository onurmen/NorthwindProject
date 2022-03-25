using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLibrary
{
    public class DBConnection
    {
        public SqlConnection conn;
        public SqlConnection Connection()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-J82AN47;Initial Catalog=NorthwindLogDB;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLibrary
{
    public class LogService
    {
        DBConnection dbCon = new DBConnection();
        public void WriteLog(string logMessage, DateTime logDate)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Logs (LogMessage,LogDate) VALUES (@LogMessage,@LogDate)", dbCon.Connection());
            cmd.Parameters.AddWithValue("@LogMessage", logMessage);
            cmd.Parameters.AddWithValue("@LogDate", logDate);
            cmd.ExecuteNonQuery();
        }
    }
}

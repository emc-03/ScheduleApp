using MySql.Data.MySqlClient;
using ScheduleApp.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp
{
    class Appointment
    {
        public int userId { get; set; }
        public int custId { get; set; }
        public int apptId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string contact { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }

   
            //string connectionString = "DB_Connection.conn";

            //using (MySqlConnection connection = new SqlConnection(connectionString))
            //    string queryString = "SELECT appointment FROM CLIENT_DATA";
            //string result = command.ExecuteScalar() as string;


   
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.Database
{
    public class DB_Connection
    {
        private static string connectionString;
        public static string ConnectionString {
            get { return connectionString; }
            set { connectionString = value; }
        }
       public static MySqlConnection conn { get; set; }
     
        public static void startConnection() {

             connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
         
            try
            {
                conn = new MySqlConnection(connectionString);
                //initializes mysql connection
                conn.Open();
                MessageBox.Show("Connection is Open");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void closeConnection() {

            //closes connection
            try { 
            if (conn != null) {
                    conn.Close();
                }
                conn = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}



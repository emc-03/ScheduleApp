using MySql.Data.MySqlClient;
using ScheduleApp.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
               
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DB_Connection.startConnection();
            Application.Run(new loginForm());
            DB_Connection.closeConnection(); // TODO Remove closeConnection 
        }
    }
}
// Order of Forms - Login - Calendar - Customer Data - 
// From Calendar - New / Update / Delete Appt --- Button to link Customer Data
// From Customer Data - New/ Update / Delete Cust. --- Button to link Calendar 
//TODO Ensure all cancel / exit buttons on each form are functional

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp
{
    class User
    {
        public static int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool activeUser { get; set; }

      

        public User(string username, string password)
        {
            username = string.Empty;
           // password = password;
            activeUser = true;

          //  string userId = DataTable.Rows[0]["userId"].ToString();
        }
    }
}

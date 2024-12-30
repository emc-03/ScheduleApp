using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.Database
{
    class UserData
    {
        // create get method to return username by userID
        
        public User Get(string userName, string password) {
            User user = new User(); // declared but not initilized until line 28

            string searchRow = "SELECT * From user WHERE username = @username AND password = @password";
            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(searchRow, connection))
                {
                    command.Parameters.AddWithValue("@username", userName);
                    command.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(); // if it returns a null user,
                            user.ID = (int)reader["userId"];
                            user.Name = userName;
                            user.Password = password;
                            string isActive = reader["active"].ToString();
                            if (isActive == "1")
                            {
                                user.IsActive = true;
                            }
                            else if (isActive == "0")
                            {
                                user.IsActive = false;
                            }
                            else
                            {
                                MessageBox.Show("User isActive value is invalid.");
                            }
                              
                        }
                        
                    }
                    
                }
                
            }
            return user;
        }
        
    }
}

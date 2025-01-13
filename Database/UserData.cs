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
        //  return username by userID
       
        public string GetUserNameById(int userId)
        {
            string username = string.Empty;

            string searchRow = "SELECT userName FROM user WHERE userId = @userId";
            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(searchRow, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            username = reader["userName"].ToString();
                        }

                    }

                }

            }
            return username;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string userQuery = "SELECT * FROM user";

            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(userQuery, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User(); // Create new User object for each row
                            user.Name = reader["userName"].ToString(); // Assign the username from the reader
                            user.ID = (int)reader["userId"];
                            users.Add(user); // Add the user to the list
                        }
                    }
                }
                connection.Close();
            }
            return users; // Return the list of users
                   }



        public User Get(string userName, string password)
        {
            User user = new User(); // declared but not initilized until line 28

            string searchRow = "SELECT * FROM user WHERE username = @username AND password = @password";
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
                            user = new User(); 
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

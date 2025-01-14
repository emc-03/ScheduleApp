using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using ScheduleApp.models;
using System.Windows.Forms;

namespace ScheduleApp.Database
{
    class AppointmentData
    {
        public List<Appointment> FindAllAppt()
        {
            List<Appointment> _reportAppointments = new List<Appointment>();

            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM appointment"; // SQL query to fetch all records

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment
                            {
                                UserID = (int)reader["userId"],
                                AppointmentID = (int)reader["appointmentId"],
                                Title = reader["title"].ToString(),
                                Description = reader["description"].ToString(),
                                Location = reader["location"].ToString(),
                                Type = reader["type"].ToString(),
                                Start = ((DateTime)reader["start"]).ToLocalTime(), // Convert UTC to local time
                                End = ((DateTime)reader["end"]).ToLocalTime(), // Convert UTC to local time
                                CreatedBy = reader["createdBy"].ToString()
                            };

                            _reportAppointments.Add(appointment);
                        }
                    }
                }
            }

            return _reportAppointments;
        }


        public List<Appointment> FindAllApptList(int _userID, int _customerID)
        {
            List<Appointment> allAppointments = new List<Appointment>();
            string apptQuery = "SELECT * FROM appointment WHERE userId = @userID AND customerId = @ID";

            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(apptQuery, connection))
                {
                    command.Parameters.AddWithValue("@userID", _userID);
                    command.Parameters.AddWithValue("@ID", _customerID);


                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.AppointmentID = (int)reader["appointmentId"];
                            appointment.CustomerID = _customerID;
                            appointment.UserID = _userID;
                            appointment.Title = reader["title"].ToString();
                            appointment.Location = reader["location"].ToString();
                            appointment.Description = reader["description"].ToString();
                            appointment.Contact = reader["contact"].ToString();
                            appointment.URL = reader["url"].ToString();
                            appointment.Start = ((DateTime)reader["start"]).ToLocalTime(); //Updated to add UTC //Convert to LocalTime
                            appointment.End = ((DateTime)reader["end"]).ToLocalTime();//Updated to add UTC //Convert to LocalTime
                            appointment.Type = reader["type"].ToString();

                            allAppointments.Add(appointment);
                        }

                    }

                }

            }
            return allAppointments;
        }
        public Appointment Add(Appointment appointment, string userName)
        {

            if (appointment == null)
            {
                throw new ArgumentNullException(nameof(appointment), "Appointment cannot be null.");
            }

            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName), "Username cannot be null.");
            }

            if (string.IsNullOrEmpty(appointment.Title))
            {
                throw new ArgumentException("Appointment title cannot be null or empty.");
            }

            string newQueryAppointment = "INSERT INTO appointment ( customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdateBy) " +
                                          "VALUES ( @customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, @createDate, @createdBy, @lastUpdateBy)";

            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(newQueryAppointment, connection))
                {

                    command.Parameters.AddWithValue("@customerId", appointment.CustomerID);
                    command.Parameters.AddWithValue("@userId", appointment.UserID);
                    command.Parameters.AddWithValue("@title", appointment.Title);
                    command.Parameters.AddWithValue("@description", appointment.Description);
                    command.Parameters.AddWithValue("@location", appointment.Location);
                    command.Parameters.AddWithValue("@contact", appointment.Contact);
                    command.Parameters.AddWithValue("@url", appointment.URL);
                    command.Parameters.AddWithValue("@start", appointment.Start.ToUniversalTime());
                    command.Parameters.AddWithValue("@end", appointment.End.ToUniversalTime());
                    command.Parameters.AddWithValue("@type", appointment.Type);
                    command.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                    command.Parameters.AddWithValue("@createdBy", userName);
                    command.Parameters.AddWithValue("@lastUpdateBy", userName);


                    command.ExecuteNonQuery();
                    appointment.AppointmentID = (int)command.LastInsertedId;
                }

                connection.Close();

            }

            return appointment;
        }


        public void Update(Appointment appointment)
        {

            List<Appointment> _appointmentList = new List<Appointment>();
            string updateQueryAppointment = "UPDATE appointment SET title = @title, description = @description, location = @location, contact = @contact, type = @type, url = @url, start = @start, end = @end" +
              " WHERE appointmentId = @appointmentId";


            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();
                {

                    using (MySqlCommand command = new MySqlCommand(updateQueryAppointment, connection))
                    {
                        command.Parameters.AddWithValue("@appointmentId", appointment.AppointmentID);
                        command.Parameters.AddWithValue("@title", appointment.Title);
                        command.Parameters.AddWithValue("@description", appointment.Description);
                        command.Parameters.AddWithValue("@location", appointment.Location);
                        command.Parameters.AddWithValue("@contact", appointment.Contact);
                        command.Parameters.AddWithValue("@url", appointment.URL);
                        command.Parameters.AddWithValue("@start", appointment.Start.ToUniversalTime());
                        command.Parameters.AddWithValue("@end", appointment.End.ToUniversalTime());
                        command.Parameters.AddWithValue("@type", appointment.Type);


                        command.ExecuteNonQuery();

                    }
                }
                connection.Close();
            }
            //does not need a return, ID is being used to match the ID in the database 
            _appointmentList.Remove(appointment);
            _appointmentList.Add(appointment);

        }

        public void Delete(Appointment appointment)
        {
            // Show confirmation message box
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this appointment?",
                "Delete Appointment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // If user confirms, proceed with the deletion
            if (result == DialogResult.Yes)
            {
                string deleteAppointment = "DELETE FROM Appointment WHERE appointmentId = @appointmentId";

                try
                {
                    // Ensure the connection is open
                    if (DB_Connection.conn.State != System.Data.ConnectionState.Open)
                    {
                        DB_Connection.conn.Open();
                    }

                    using (MySqlCommand command = new MySqlCommand(deleteAppointment, DB_Connection.conn))
                    {
                        command.Parameters.AddWithValue("@appointmentId", appointment.AppointmentID);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Appointment deleted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    MessageBox.Show("An error occurred while deleting the appointment.");
                    throw;
                }
                finally
                {
                    // close connection
                    if (DB_Connection.conn.State == System.Data.ConnectionState.Open)
                    {
                        DB_Connection.conn.Close();
                    }
                }
            }
            else
            {
                // do nothing if user clicks cancel
                MessageBox.Show("Appointment deletion canceled.");
            }
        }

        public void DeleteAppointmentsByCustomer(int customerId)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete all appointments for this customer?",
                "Delete Appointments",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // User confirms 'yes' then delete
            if (result == DialogResult.Yes)
            {
                string deleteAppointmentsQuery = "DELETE FROM Appointment WHERE customerId = @customerId;";

                try
                {
                    // Ensure the connection is open
                    if (DB_Connection.conn.State != System.Data.ConnectionState.Open)
                    {
                        DB_Connection.conn.Open();
                    }

                    using (MySqlCommand command = new MySqlCommand(deleteAppointmentsQuery, DB_Connection.conn))
                    {
                        command.Parameters.AddWithValue("@customerId", customerId);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("All appointments for this customer have been deleted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    MessageBox.Show("An error occurred while deleting appointments.");
                    throw;
                }
                finally
                {
                    //checks for closed connection
                    if (DB_Connection.conn.State == System.Data.ConnectionState.Open)
                    {
                        DB_Connection.conn.Close();
                    }
                }
            }
            else
            {
                // do nothing if user clicks cancel
                MessageBox.Show("Appointment deletion canceled.");
            }
        }



    }

}





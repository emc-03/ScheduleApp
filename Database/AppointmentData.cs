using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using ScheduleApp.models;

namespace ScheduleApp.Database
{
    class AppointmentData
    {

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
                            appointment.ID = (int)reader["appointmentId"];
                            appointment.CustomerID = _customerID;
                            appointment.UserID = _userID;
                            appointment.Contact = reader["contact"].ToString();
                            appointment.Description = reader["description"].ToString();
                            appointment.Start = (DateTime)reader["start"];
                            appointment.End = (DateTime)reader["end"];
                            appointment.Location = reader["location"].ToString();
                            appointment.Title = reader["title"].ToString();
                            appointment.Type = reader["type"].ToString();
                            appointment.URL = reader["url"].ToString();

                            allAppointments.Add(appointment);
                        }

                    }

                }

            }
            return allAppointments;
        }

        public Appointment Add(Appointment appointment)
        {
           

            string newQueryAppointment = "INSERT INTO appointment (appointmentStart, appointmentEnd, appointmentTitle, appointmentType, appointmentLocation, appointmentDescription, appointmentContact)" +
                "VALUES (@appointmentStart, @appointmentEnd, @appointmentTitle, @appointmentType, @appointmentLocation, @appointmentDescription, @appointmentContact)";



            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(newQueryAppointment, connection))
                {
                    command.Parameters.AddWithValue("@appointmentStart", appointment.Start);
                    command.Parameters.AddWithValue("@appointmentEnd", appointment.End);
                    command.Parameters.AddWithValue("@appointmentTitle", appointment.Description);
                    command.Parameters.AddWithValue("@appointmentType", appointment.Type);
                    command.Parameters.AddWithValue("@appointmentLocation", appointment.Location);
                    command.Parameters.AddWithValue("@appointmentDescription", appointment.Title);
                    command.Parameters.AddWithValue("@appointmentContact", appointment.Contact);
                    
                    

                    command.ExecuteNonQuery();

                     appointment.ID = (int)command.LastInsertedId;

                }

                connection.Close();
            }
            return appointment;
        }

        public void Update(Appointment appointment)
        {
           

            string updateQueryAppointment = "UPDATE appointment SET Title = @Title, Start = @Start WHERE appointmentId = @ID";

            {

                using (MySqlCommand command = new MySqlCommand(updateQueryAppointment, DB_Connection.conn))
                {
                    command.Parameters.AddWithValue("@Title", appointment.Description);
                    command.Parameters.AddWithValue("@Start", appointment.Start);
                    command.Parameters.AddWithValue("@ID", appointment.ID);

                    command.ExecuteNonQuery();

                }
            }
            //does not need a return, ID is being used to match the ID in the database 
        }
        // Delete 


        //user and customer appointment list 
        //SELECT FROM WHERE  userID == customerID 
        //make list of an appointments, read one row at a time, creating a single appointment, set values, declare a list outside of the loop,
        //then return all matching appointments 




        //  public void loadDataGrid()
        // {
        //{
        //    _calendarList = _customerData.FindAll();
        //    BindingSource source = new BindingSource();
        //    source.DataSource = _customerList;
        //    dataGridCustomer.DataSource = source;


        // TODO Binding list to make sure that when a row is selected that the full customer is available 


        //    public void loadDataGrid()
        //    {
        //        if (monthRadioButton.Checked = true)
        //        {

        //            loadMonthView();
        //        }
        //        else if (weekRadioButton.Checked = true)
        //        {
        //            string getAppt = "SELECT * FROM appointment";



        //            //loadWeekView();
        //        }
        //        SELECT * FROM client_schedule.appointment
        //WHERE start >= CURDATE() - INTERVAL WEEKDAY(CURDATE()) day AND start < CURDATE() - INTERVAL weekday(CURDATE()) day + interval 7 day;
        //        {
        //            //loadAll();
        //        }
        //    }

        //    private void loadMonthView()
        //    {
        //SELECT* FROM client_schedule.appointment
        //WHERE YEAR(start) = YEAR(CURDATE()) AND MONTH(CURDATE()) = MONTH(CURDATE());
        //        DataTable dataTable = new DataTable();
        //        dataTable.Columns.Add(""); //Date 
        //        dataTable.Columns.Add(""); // Event 


        //    }
        //}

        //private void loadWeekView()
        //{

        //}
        //private void loadAll()
        //{

        //}
    }
}


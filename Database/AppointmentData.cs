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
        private Appointment _selectedAppointment;
        private List<Appointment> _appointmentList = new List<Appointment>();



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
                            appointment.Title = reader["title"].ToString();
                            appointment.Description = reader["description"].ToString();
                            appointment.Contact = reader["contact"].ToString();
                            appointment.URL = reader["url"].ToString();
                            appointment.Start = (DateTime)reader["start"];
                            appointment.End = (DateTime)reader["end"];
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

            if (string.IsNullOrEmpty(appointment.Title))
            {
                throw new ArgumentException("Appointment title cannot be null or empty.");
            }

            string newQueryAppointment = "INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdateBy) " +
                                          "VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, @createDate, @createdBy, @lastUpdateBy)";

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
                    command.Parameters.AddWithValue("@start", appointment.Start);
                    command.Parameters.AddWithValue("@end", appointment.End);
                    command.Parameters.AddWithValue("@type", appointment.Type);
                    command.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                    command.Parameters.AddWithValue("@createdBy", userName);
                    command.Parameters.AddWithValue("@lastUpdateBy", userName);
                   

                    command.ExecuteNonQuery();
                    appointment.ID = (int)command.LastInsertedId;
                }

                connection.Close();
            }

            return appointment;
        }


        public void Update(Appointment appointment)
        {


            string updateQueryAppointment = "UPDATE appointment SET (title, description, location, contact, type, url, start, end)" +
                "VALUES (@title, @description, @location, @contact, @type, @url, @start, @end)";
            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();
                {

                    using (MySqlCommand command = new MySqlCommand(updateQueryAppointment, connection))
                    {
                        command.Parameters.AddWithValue("@title", appointment.Title);
                        command.Parameters.AddWithValue("@description", appointment.Description);
                        command.Parameters.AddWithValue("@location", appointment.Location);
                        command.Parameters.AddWithValue("@contact", appointment.Contact);
                        command.Parameters.AddWithValue("@url", appointment.URL);
                        command.Parameters.AddWithValue("@start", appointment.Start);
                        command.Parameters.AddWithValue("@end", appointment.End);
                        command.Parameters.AddWithValue("@type", appointment.Type);


                        command.ExecuteNonQuery();
                        appointment.ID = (int)command.LastInsertedId;
                    }
                }
                connection.Close();
            }
            //does not need a return, ID is being used to match the ID in the database 
        }

        public void Delete(Appointment appointment)
        {

            string deleteAppointment = "DELETE FROM Appointment Where appointmentId = @appointmenId";

            using (MySqlCommand command = new MySqlCommand(deleteAppointment, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@appointmentId", appointment.ID);
                command.ExecuteNonQuery();
            }
            AppointmentData appointmentData = new AppointmentData();
            appointmentData.Delete(appointment);
        }



    }

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



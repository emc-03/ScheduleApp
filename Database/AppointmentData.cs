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
        /*
        public List<Appointment> FindAllApptList_noCust(int _userID)
        {
            List<Appointment> allAppointments = new List<Appointment>();
            string apptQuery = "SELECT * FROM appointment WHERE userId = @userID";

            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(apptQuery, connection))
                {
                    command.Parameters.AddWithValue("@userID", _userID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.ID = (int)reader["appointmentId"];
                            appointment.CustomerID = (int)reader["customerId"];
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

        public List<Appointment> FindAll(int userId)
        {
            List<Appointment> appointmentFindAllList = new List<Appointment>();
            string getAppointment = "SELECT * FROM appointment"; // Not filtering by userId
            AddressData addressData = new AddressData();
            AppointmentData appointmentData = new AppointmentData();

            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(getAppointment, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.ID = (int)reader["appointmentId"];
                            appointment.AppointmentList = appointmentData.FindAllApptList_noCust(userId);

                            appointmentFindAllList.Add(appointment);
                        }
                    }
                }
                connection.Close();
            }

            return appointmentFindAllList;
        }
        */
        // Create Add, Update, Delete 


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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp.Database
{
    class AppointmentData
    {
        //findCustomerID - find list of appointments to call appointmentData when pulling a customer out of the database
        //findUserID
        public List<Appointment> FindAllApptList(int userID, int customerID) { 
            //user and customer appointment list 
           //SELECT FROM WHERE  userID == customerID 
           //make list of an appointments, read one row at a time, creating a single appointment, set values, declare a list outside of the loop,
           //then return all matching appointments 
        }

        public void loadDataGrid()
        {
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
}

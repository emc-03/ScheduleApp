using MySql.Data.MySqlClient;
using ScheduleApp.Database;
using ScheduleApp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp


{
    public partial class MonthlyReportMain : Form
    {
    
        private AppointmentData _appointmentData = new AppointmentData();

        public MonthlyReportMain()
        {
            InitializeComponent();

        }
      

        public void loadDataToList() //NEW
        {
            // 1) Use the private field for AppointmentData to call FindAll() to get a list of all of the appointments from the database.
            // Store this in a variable of type List<Appointment>
            //2) Assign column names to the DataGridView, such as "Appointment Type", "January", "February", "March", etc.
            //3) Group the Appointments, first by appointment type, and then by month
            //Go through the groups and count the appointments in each month and use it to populate the row values.
            //Remember that the first column should display the type.
            //Then you add the count values after that in order of the month they happened in

           List<Appointments> allDataAppointments = _appointmentData.FindAllAppt();


        }
            private void MonthlyReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

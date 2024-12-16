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
        private List<Appointment> _appointments;
      


        public MonthlyReportMain()
        {
            InitializeComponent();
            loadDataToList();
            PopultateDataGridReport();

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
            _appointments = _appointmentData.FindAllAppt();
        }
        private void PopulateDataGridView()
        {
            // define columns
            dataGridMonthlyReport.Columns.Clear();
            dataGridMonthlyReport.Columns.Add("Type", "Appointment Type");
            //change type for months
            dataGridMonthlyReport.Columns.Add("Type", "January"); 
            dataGridMonthlyReport.Columns.Add("Type", "February");
            dataGridMonthlyReport.Columns.Add("Type", "March"); 
            dataGridMonthlyReport.Columns.Add("Type", "April"); 
            dataGridMonthlyReport.Columns.Add("Type", "May"); 
            dataGridMonthlyReport.Columns.Add("Type", "June"); 
            dataGridMonthlyReport.Columns.Add("Type", "July"); 
            dataGridMonthlyReport.Columns.Add("Type", "August"); 
            dataGridMonthlyReport.Columns.Add("Type", "September"); 
            dataGridMonthlyReport.Columns.Add("Type", "October"); 
            dataGridMonthlyReport.Columns.Add("Type", "November");
            dataGridMonthlyReport.Columns.Add("Type", "December");

            Dictionary<string, List<Appointment>> appointmentTypeDictionary = new Dictionary<string, List<Appointment>>();
            //the dictionary key is the appt type
            //foreach loop over _appointments 
            //add to the dictionary
            //1) Check if the dictionary has the appointment type as a key already
            //2) If so, grab the list of appointments(the value associated with that key) for that appointment type from the dictionary
            //and add the current appointment to it
           // 3) If not, add the key and assign the value as a new List<Appointment> with the current appointment as the only one in the list


            for (int i = 0; i < 1000; i++)
            {
               // dataGridMonthlyReport.Columns.Add(i.ToString(), new DateTime())
            }
            // use appt type as key *dictionary 
            // put  the apptdata from a list to a dictionary 
          
        }

        private void MonthlyReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

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
            PopulateDataGridView();

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

            foreach (var appointment in _appointments)
            {
                if (appointmentTypeDictionary.ContainsKey(appointment.Type))
                {
                    //add appt to existing list
                    appointmentTypeDictionary[appointment.Type].Add(appointment);
                }

                else
                {
                    appointmentTypeDictionary[appointment.Type] = new List<Appointment>
                    { appointment};
                }
            }
            //Clear and prep the datagridview to calculate montly types

            dataGridMonthlyReport.Columns.Clear();
            dataGridMonthlyReport.Columns.Add("Type", "Appointment Type");
            /*foreach loop over _appointments 
            add to the dictionary
            1) Check if the dictionary has the appointment type as a key already
            2) If so, grab the list of appointments(the value associated with that key) for that appointment type from the dictionary
            and add the current appointment to it
            3) If not, add the key and assign the value as a new List<Appointment> with the current appointment as the only one in the list
                use appt type as key *dictionary 
                put  the apptdata from a list to a dictionary 
            */
            for (int i = 0; i < 12; i++)
            {
                // add column to DataGridView ** change to ROW ? 
                // dataGridMonthlyReport.Columns.Add(i.ToString(), new DateTime())
                dataGridMonthlyReport.Columns.Add((i + 1).ToString(), new DateTime(1, i + 1, 1).ToString("MMMM"));

            }
            foreach (var appt in appointmentTypeDictionary)

            {
                string type = appt.Key;
                var monthlyCounts = new int[12];
                // count appointments per month

                foreach (var appointment in appt.Value)
                {
                    monthlyCounts[appointment.Start.Month - 1]++;
                }

                // Create a row with type and montly counts 
                var rowValues = new object[13];
                rowValues[0] = type; // first column for column type

                Array.Copy(monthlyCounts, 0, rowValues, 1, 12); // copy montly counts into the array

                //add the row to the DataGridView

                dataGridMonthlyReport.Rows.Add(rowValues);
                /*Pass the array of values directly, ensuring it matches the column count and data types expected by the DataGridView, hopefully \_''_/ */
                // if this doesn't work - explicitly conver the rowValues to DataGridViewRow 
                /* var dataGridViewRow = new DataGridViewRow();
                 * dataGridViewRow.CreateCells(dataGridMontlyReport, rowValues);
                 * dataGridMonthlyReport.Rows.Add(dataGridViewRow);*/

            }


        }

        private void MonthlyReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitReport_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

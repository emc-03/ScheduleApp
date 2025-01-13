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
    public partial class MonthlyCurrentYearReport : Form
    {

        private AppointmentData _appointmentData = new AppointmentData();
        private List<Appointment> _appointments;

        public MonthlyCurrentYearReport()
        {
            InitializeComponent();
            loadDataToList();
            PopulateDataGridView();

        }

        public void loadDataToList() 
        {
            // Lambda is shorthand version to conveys the filtering logic and doesn't require a sepearate method.
            //appointments, where the start date is in the current year
            _appointments = _appointmentData.FindAllAppt().FindAll(a => a.Start.Year == DateTime.Now.Year);
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
            //prep the datagridview to calculate monthly types

            dataGridMonthlyReport.Columns.Clear();
            dataGridMonthlyReport.Columns.Add("Type", "Appointment Type");

            for (int i = 0; i < 12; i++)
            {

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

                Array.Copy(monthlyCounts, 0, rowValues, 1, 12); // copy monthly counts into the array

                //add the row to the DataGridView
                dataGridMonthlyReport.Rows.Add(rowValues);

            }

        }
        private void exitReport_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonthlyReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void MonthlyCurrentYearReport_Load(object sender, EventArgs e) { }
     
    }
}

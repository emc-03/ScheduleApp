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
        private User _user;
        private Customer _selectedCustomer;
        private Appointment _selectedAppointment;
        private AppointmentData _appointmentData = new AppointmentData();

        // TODO - update to grab all appointments as we need data for ALL users
        public MonthlyReportMain()
        {
            InitializeComponent();
        }
        public MonthlyReportMain(Customer selectedCustomer, User user)
        {
            _user = user;
            _selectedCustomer = selectedCustomer;

            loadDataToList();
        }

        public void loadDataToList() //NEW
        {
            var appointmentSummary = _selectedCustomer.AppointmentList
            // assign to correct type from DatePicker
            .GroupBy(a => new { Year = a.Start.Year, Month = a.Start.Month, Type = a.Type }) 
            .OrderBy(a => a.Year)
            .ThenBy(a => a.Month)
            .ToList();

            dataGridMonthlyReport.DataSource = null;  // Clear the existing data source

            dataGridMonthlyReport.DataSource = appointmentSummary;// Bind the updated list

        }
            private void MonthlyReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

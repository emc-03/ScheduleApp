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
    public partial class UserReportMain : Form
    {

        private List<Appointment> _appointmentsUserReport;
        private AppointmentData _appointmentData = new AppointmentData();
        // adjust loadappointment data to use the Appointmentdata class

        public UserReportMain()
        {
            InitializeComponent();
            LoadAppointmentData();
            PopulateUserReportGrid();


        }

        private void LoadAppointmentData()
        {
            _appointmentsUserReport = _appointmentData.FindAllAppt();

            // Add the appointment to the list
            // add conditional checks for null values in each column / row 

        }

        private void PopulateUserReportGrid()
        {
            userReportDataGrid.Columns.Clear();
            userReportDataGrid.Columns.Add("Type", "User");
            userReportDataGrid.Columns.Add("Type", "Title");
            userReportDataGrid.Columns.Add("Type", "Description");
            userReportDataGrid.Columns.Add("Type", "Appointment Date");
            userReportDataGrid.Columns.Add("Type", "Appointment Time");
            userReportDataGrid.Columns.Add("Type", "Location");

            foreach (Appointment appointment in _appointmentsUserReport)
            {
                addAppointmentToUserReport(appointment);
            }

        }

        private void addAppointmentToUserReport(Appointment appointment)

        {
            userReportDataGrid.Rows.Add
                (appointment.UserID,
                appointment.Title,
                appointment.Description,
                appointment.Start.ToString("MM/dd/yyyy"),
                appointment.Start.ToString("hh:mm"),
                appointment.Location);
        }



        private void UserReportMain_Load(object sender, EventArgs e)
        {

        }

        private void userReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userReportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitReport_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

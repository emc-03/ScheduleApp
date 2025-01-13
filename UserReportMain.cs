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


        public UserReportMain()
        {
            InitializeComponent();


            LoadAppointmentData();
            PopulateUserReportGrid();
            LoadUsersToDropdown();


        }

        private void LoadAppointmentData()
        {
            _appointmentsUserReport = _appointmentData.FindAllAppt();

            if (_appointmentsUserReport == null || !_appointmentsUserReport.Any())
            {
                MessageBox.Show("No appointments found.");
                _appointmentsUserReport = new List<Appointment>(); // empty list
            }
        }

        private void PopulateUserReportGrid()
        {
            userReportDataGrid.Columns.Clear();
            userReportDataGrid.Columns.Add("Title", "Title");
            userReportDataGrid.Columns.Add("Description", "Description");
            userReportDataGrid.Columns.Add("Start", "Appointment Date");
            userReportDataGrid.Columns.Add("Start", "Appointment Time");
            userReportDataGrid.Columns.Add("Location", "Location");

        }

        private void addAppointmentToUserReport(Appointment appointment)

        {
            if (appointment != null)
            {
                userReportDataGrid.Rows.Add
                    (
                    appointment.Title,
                    appointment.Description,
                    appointment.Start.ToString("MM/dd/yyyy"),
                    appointment.Start.ToString("hh:mm"),
                    appointment.Location
                    );
            }
        }

        private void LoadUsersToDropdown()
        {

            try
            {
                userDropDown.Items.Clear();

                UserData userData = new UserData();
                List<User> users = userData.GetAllUsers();

                if (users == null || users.Count <= 0)
                {
                    MessageBox.Show("No users found.");
                    return;
                }

                // Use a lambda expression with ForEach to add users to the dropdown
                // Lambda makes it clear that adding items to the dropdown is directly tied to the processing of the users list.
                users.ForEach(user => userDropDown.Items.Add(user));

                userDropDown.DisplayMember = "Name";

                if (userDropDown.Items.Count > 0)
                {
                    userDropDown.SelectedIndex = 0; // Select the first user by default
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }
        }

        private void exitReport_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

            User selectedUser = userDropDown.SelectedItem as User;
            userReportDataGrid.Rows.Clear();
            foreach (Appointment appointment in _appointmentsUserReport)
            {
                if (appointment.UserID == selectedUser.ID)
                {
                    addAppointmentToUserReport(appointment);
                }

            }

        }
        private void UserReportMain_Load(object sender, EventArgs e) { }
        private void userReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void userReportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
       
    }
}


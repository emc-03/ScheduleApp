using MySql.Data.MySqlClient;
using ScheduleApp.Database;
using ScheduleApp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp
{
    public partial class calendarForm : Form

    {
        private User _user;
        private Customer _selectedCustomer;
        private Appointment _selectedAppointment;
        private AppointmentData _appointmentData = new AppointmentData();

        public calendarForm(Customer selectedCustomer, User user)
        {
            _user = user;
            _selectedCustomer = selectedCustomer;

            InitializeComponent();
            loadDataToList();

        }

        private void DisplayCurrentUsername(int userId)
        {
            try
            {
                UserData userData = new UserData();
                string username = userData.GetUserNameById(userId);

                if (!string.IsNullOrEmpty(username))
                {
                    userNamePrint.Text = username;
                }
                else
                {
                    userNamePrint.Text = "User not found";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching username: {ex.Message}");
            }
        }
        public void CreatedAppointmentListener(Appointment appointment)
        {
            _selectedCustomer.AppointmentList.Add(appointment);
            FilterAppointmentByRadioButton();
        }

        public void UpdatedAppointmentListener(Appointment appointment)
        {
            int updatedAppointmentIndex = _selectedCustomer.AppointmentList.FindIndex(a => a.AppointmentID == appointment.AppointmentID);
            _selectedCustomer.AppointmentList[updatedAppointmentIndex] = appointment;
            FilterAppointmentByRadioButton();
        }
        public void loadDataToList() //NEW
        {

            appointmentDataGrid.DataSource = null;  // Clear the existing data source

            appointmentDataGrid.DataSource = _selectedCustomer.AppointmentList;// Bind the updated list
        }

        // Filter logic for List - timedate
        private void FilterByDate()
        {
            var filteredList = _selectedCustomer.AppointmentList.FindAll(appointment => appointment.Start.Date == dateTimePicker1.Value.Date);


            // Bind the filtered list to the DataGridView
            appointmentDataGrid.DataSource = filteredList;
        }


        // Filter the list by this week
        private void FilterByThisWeek()
        {
            DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);  // Start of the current week (Sunday)
            DateTime endOfWeek = startOfWeek.AddDays(7);  // End of the current week (Saturday)

            var filteredList = _selectedCustomer.AppointmentList.FindAll(appointment => appointment.Start >= startOfWeek && appointment.Start < endOfWeek);

            // Bind the filtered list to the DataGridView
            appointmentDataGrid.DataSource = filteredList;
        }

        // Filter the list by this month
        private void FilterByThisMonth()
        {
            DateTime startOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);  // Start of the month
            DateTime startOfNextMonth = startOfMonth.AddMonths(1);  // Start of the next month

            var filteredList = _selectedCustomer.AppointmentList.FindAll(appointment => appointment.Start >= startOfMonth && appointment.Start < startOfNextMonth);

            // Bind the filtered list to the DataGridView
            appointmentDataGrid.DataSource = filteredList;
        }

        // filters based on radio button selection
        private void FilterAppointmentsByDateRange(string filterType)
        {
            switch (filterType)
            {

                case "ThisWeek":
                    FilterByThisWeek();
                    break;
                case "ThisMonth":
                    FilterByThisMonth();
                    break;
                case "ALL":
                    loadDataToList();
                    break;
                case "SelectedDate":
                    FilterByDate();
                    break;
            }
        }


        private void FilterAppointmentByRadioButton()
        {
            if (dayRadioButton.Checked)
            {
                FilterByDate();
            }
            else if (weekRadioButton.Checked)
            {
                FilterByThisWeek();
            }
            else if (monthRadioButton.Checked)
            {
                FilterByThisMonth();
            }
            //if no radio button is selected or if all is checked
            else
            {
                loadDataToList();
            }

        }

        private void selectRow()

        {

            Int32 rowCount = appointmentDataGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            // Int32 rowCount = appointmentDataGrid.SelectedRows.Count;
            // if more then 1 row was selected they can't update more than one customer at a time. S
            if (rowCount > 0)
            {
                var rawSelectedAppointmentId = appointmentDataGrid.SelectedRows[0].Cells["appointmentId"].Value;
                // int selectedAppointmentID = Convert.ToInt32(appointmentDataGrid.SelectedRows[0].Cells["appointmentID"].Value);
                if (rawSelectedAppointmentId == null || !int.TryParse(rawSelectedAppointmentId.ToString(), out int selectedAppointmentID))

                {
                    return;
                }
                // Check if the appointment with the selected ID exists in the list
                if (_selectedCustomer.AppointmentList.Any(appointment => appointment.AppointmentID == selectedAppointmentID))
                {
                    _selectedAppointment = _selectedCustomer.AppointmentList.First(appointment => appointment.AppointmentID == selectedAppointmentID);
                }
                else
                {
                    MessageBox.Show("Could not find Appointment in memory.");
                }

            }
            else
            {
                MessageBox.Show("No row selected.");
            }

        }

        private void customerDataButton_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void upCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void apptTaskLabel_Click(object sender, EventArgs e)
        {

        }

        private void createApptButton_Click(object sender, EventArgs e)
        {
            CreateAppointmentForm _createAppointmentForm = new CreateAppointmentForm(_selectedCustomer, _user);
            _createAppointmentForm.CreatedAppointment += CreatedAppointmentListener;
            _createAppointmentForm.Show();
        }


        private void updateApptButton_Click(object sender, EventArgs e)
        {
            selectRow();


            if (_selectedAppointment != null)
            {
                UpdateAppointmentForm updateAppointmentForm = new UpdateAppointmentForm(_selectedAppointment, _selectedCustomer.AppointmentList);
                updateAppointmentForm.UpdatedAppointment += UpdatedAppointmentListener;

                updateAppointmentForm.Show();
                _selectedAppointment = null;
            }
            else
            {
                MessageBox.Show("No Appointment Selected!");


            }
        }

        private void dayViewRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (dayRadioButton.Checked)
            {
                FilterAppointmentsByDateRange("SelectedDate");
            }

        }

        private void weekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FilterAppointmentsByDateRange("ThisWeek");
        }

        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FilterAppointmentsByDateRange("ThisMonth");
        }

        private void allApptRadio_CheckedChanged(object sender, EventArgs e)
        {
            FilterAppointmentsByDateRange("ALL");
        }



        private void deleteAppointmentButton_Click(object sender, EventArgs e)
        {
            selectRow();
            if (_selectedAppointment != null)
            {
                // delete from database
                _appointmentData.Delete(_selectedAppointment);

                // delete from customers appointments
                int selectedAppointmentIndex = _selectedCustomer.AppointmentList.FindIndex(a => a.AppointmentID == _selectedAppointment.AppointmentID);
                _selectedCustomer.AppointmentList.RemoveAt(selectedAppointmentIndex);
                // update the datagrid with all new appointments
                FilterAppointmentByRadioButton();
                //delete was successful 
                _selectedAppointment = null;

                MessageBox.Show("Appointment has been deleted.");

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dayRadioButton != null)
            {
                dayRadioButton.Checked = true;
                FilterAppointmentByRadioButton();
            }

        }

        private void userNamePrint_TextChanged(object sender, EventArgs e)
        {


            // Validate and retrieve userId
            if (int.TryParse(userNamePrint.Text, out int userId))
            {
                DisplayCurrentUsername(userId);
            }
            else
            {
                userNamePrint.Text = "Invalid username";
            }
        }
        private void appointmentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void appointmentDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) { }
        private void searchApptButton_Click(object sender, EventArgs e) { }
        private void bindingMonthList_CurrentChanged(object sender, EventArgs e) { }
        private void bindingWeekList_CurrentChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void apptViewLabel_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }


    }
}



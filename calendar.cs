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
            //loadData();
            loadDataToList();

        }

        public void CreatedAppointmentListener(Appointment appointment)
        {
            _selectedCustomer.AppointmentList.Add(appointment);
            loadDataToList();
        }

        public void UpdatedAppointmentListener(Appointment appointment)
        {
            int updatedAppointmentIndex = _selectedCustomer.AppointmentList.FindIndex(a => a.AppointmentID == appointment.AppointmentID);
            _selectedCustomer.AppointmentList[updatedAppointmentIndex] = appointment;
            loadDataToList();
        }
        public void loadDataToList() //NEW
        {

            // Rebind the list to the DataGridView to display the updated list
            appointmentDataGrid.DataSource = null;  // Clear the existing data source
            appointmentDataGrid.DataSource = _selectedCustomer.AppointmentList;// _appointmentList2;  // Bind the updated list
        }





        /////// New Filter logic for List instead of datatable
        private void FilterByDate()
        {
            var filteredList = _selectedCustomer.AppointmentList.FindAll(appointment => appointment.Start.Date == dateTimePicker1.Value.Date);


            // Bind the filtered list to the DataGridView
            appointmentDataGrid.DataSource = filteredList;
        }

        private void FilterByToday()
        {
            var filteredList = _selectedCustomer.AppointmentList.FindAll(appointment => appointment.Start == DateTime.Today);

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



        // Example of calling the filters based on radio button selection
        private void FilterAppointmentsByDateRange(string filterType)
        {
            switch (filterType)
            {
                case "Today":
                    FilterByToday();
                    break;
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
                UpdateAppointmentForm updateAppointmentForm = new UpdateAppointmentForm(_selectedAppointment);
                updateAppointmentForm.UpdatedAppointment += UpdatedAppointmentListener;


                updateAppointmentForm.Show();
                _selectedAppointment = null;
            }
            else
            {
                MessageBox.Show("No Appointment Selected!");


            }
        }

        private void appointmentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dayViewRadio_CheckedChanged(object sender, EventArgs e)
        {
            FilterAppointmentsByDateRange("SelectedDate");
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

        private void searchApptButton_Click(object sender, EventArgs e)
        {

        }

        private void bindingMonthList_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingWeekList_CurrentChanged(object sender, EventArgs e)
        {

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
                loadDataToList();
                //delete was successful 
                _selectedAppointment = null;

                MessageBox.Show("Appointment has been deleted.");

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void apptViewLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        private Appointment _appointment;
        private readonly AppointmentData _appointmentData = new AppointmentData();

        public calendarForm(Customer selectedCustomer, User user)
        {
            _user = user;
            _selectedCustomer = selectedCustomer;

            InitializeComponent();
            loadData();

        }

        public void loadData()
        {
            // Clear existing columns to avoid duplication
            appointmentDataGrid.Columns.Clear();

            // Add necessary columns if they don't exist
            appointmentDataGrid.Columns.Add("appointmentTitle", "Title");
            appointmentDataGrid.Columns.Add("appointmentDescription", "Description");
            appointmentDataGrid.Columns.Add("appointmentLocation", "Location");
            appointmentDataGrid.Columns.Add("appointmentContact", "Contact");
            appointmentDataGrid.Columns.Add("appointmentType", "Appointment Type");
            appointmentDataGrid.Columns.Add("appointmentStart", "Start Time");
            appointmentDataGrid.Columns.Add("appointmentEnd", "End Time");
            appointmentDataGrid.Columns.Add("appointmentID", "ID");

            // Hide the ID column
            appointmentDataGrid.Columns["appointmentID"].Visible = false;

            // Clear previous rows to avoid duplicates
            appointmentDataGrid.Rows.Clear();

            // Add each appointment to the DataGridView
            foreach (Appointment appointment in _selectedCustomer.AppointmentList)
            {
                addAppointmenttoDataGrid(appointment);
            }

            // Alternative: Bind the AppointmentList directly to the DataGridView
            // This automatically creates columns and rows based on the AppointmentList
            // appointmentDataGrid.DataSource = _selectedCustomer.AppointmentList;
        }

        // Helper method to add appointment details to the DataGridView
        private void addAppointmenttoDataGrid(Appointment appointment)
        {
            appointmentDataGrid.Rows.Add(
                appointment.Title,
                appointment.Description,
                appointment.Location,
                appointment.Contact,
                appointment.Type,
                appointment.Start,
                appointment.End,
                appointment.ID
            );
        }

        public void Delete(Appointment appointment)
        {
            selectRow();
            if (_appointment != null)
            {
                _appointmentData.Delete(_appointment);
                int rowIndex = appointmentDataGrid.SelectedRows[0].Index;
                appointmentDataGrid.Rows.RemoveAt(rowIndex);

                MessageBox.Show("Customer information ha been deleted.");
            
            }

        }

        //NEW STUFF
        // Filter the DataGridView by today's date

        /*
        private void FilterByToday()
        {
            DataView dv = ;
            dv.RowFilter = $"StartDate >= #{DateTime.Today}# AND StartDate < #{DateTime.Today.AddDays(1)}#";
        }

        // Filter the DataGridView by this week
        private void FilterByThisWeek()
        {
            DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);  // Start of the current week (Sunday)
            DateTime endOfWeek = startOfWeek.AddDays(7);  // End of the current week

            DataView dv = _appointment;
            dv.RowFilter = $"StartDate >= #{startOfWeek}# AND StartDate < #{endOfWeek}#";
        }

        // Filter the DataGridView by this month
        private void FilterByThisMonth()
        {
            DateTime startOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);  // Start of the month
            DateTime startOfNextMonth = startOfMonth.AddMonths(1);  // Start of the next month

            DataView dv = _appointment.DefaultView;
            dv.RowFilter = $"StartDate >= #{startOfMonth}# AND StartDate < #{startOfNextMonth}#";
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
            }
        }

        //ENDNEWSTUFF
        */

        private void selectRow()

        {


            Int32 rowCount = appointmentDataGrid.SelectedRows.Count;
            // if more then 1 row was selected they can't update more than one customer at a time. 
            if (rowCount > 0)
            {
                int selectedAppointmentID = Convert.ToInt32(appointmentDataGrid.SelectedRows[0].Cells["appointmentID"].Value);
                Appointment selectedAppointment = _selectedCustomer.AppointmentList.FirstOrDefault(a => a.ID == selectedAppointmentID);

                if (selectedAppointment == null)
                {

                    MessageBox.Show("Could not find Customer in memory.");
                }
                else
                {
                    _appointment = selectedAppointment;
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
            // CustomerInformationForm custData = new CustomerInformationForm();
            //custData.Show();

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

            CreateAppointment create = new CreateAppointment(_selectedCustomer, _user);

            create.Show();
        }

        private void updateApptButton_Click(object sender, EventArgs e)
        {
            selectRow();


            if (_appointment != null)
            {
                updateAppt update = new updateAppt(_appointment);
                update.Show();
            }
            else
            {
                MessageBox.Show("No Appointment Selected!");
                //TO-DO create a method for each radio button, fill the data table then call the correct Method in the SQL statement

            }
        }

        private void appointmentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }



        private void weekRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchApptButton_Click(object sender, EventArgs e)
        {
            try
            {
                //string connectionString = "?";
                //string searchAppt = TextBox.?; TODO What do I reference ? 

                //using (MySqlConnection connection = new MySqlConnection(connectionString));
                // search the query 

            }
            catch
            {
                MessageBox.Show("Appointment could not be found!");
            }

            // when monthRadioButton selected 
            /*   string monthConnection = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString; // table for test use - TODO  where to find the connection string?; 

             create sql object 
            gridConnection = new SqlConnection(monthConnection);
             create dataAdapter object
            adapter = new SqlDataAdapter("SELECT * FROM client_schedule", monthConnection);
             create a Dataset Object 
            data = new DataSet();
            adapter.Fill(data, "client_schedule");
            monthDataGrid.DataSource = data.Tables["client_schedule"];
            */

        }

        private void bindingMonthList_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingWeekList_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dayViewRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void deleteAppointmentButton_Click(object sender, EventArgs e)
        {
          //call delete method here

        }
    }
}

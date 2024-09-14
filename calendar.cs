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
        
        private Customer _selectedCustomer;
        private Appointment _appointment;


        public calendarForm(Customer selectedCustomer)
        {
            
            _selectedCustomer = selectedCustomer;

            InitializeComponent();
            loadData();

        }

        public void loadData()
        {
            //_appointmentList = _appointmentData.FindAll(userId);
            appointmentDataGrid.Columns.Add("appointmentStart", "Start Time");
            appointmentDataGrid.Columns.Add("appointmentEnd", "End Time");
            appointmentDataGrid.Columns.Add("appointmentTitle", "Title");
            appointmentDataGrid.Columns.Add("appointmentType", "Appointment Type");
            appointmentDataGrid.Columns.Add("appointmentLocation", "Location");
            appointmentDataGrid.Columns.Add("appointmentDescription", "Description");
            appointmentDataGrid.Columns.Add("appointmentContact", "Contact");
            appointmentDataGrid.Columns.Add("appointmentID", "ID");
            appointmentDataGrid.Columns["appointmentID"].Visible = false;

            foreach (Appointment appointment in _selectedCustomer.AppointmentList)
            {
                addAppointmenttoDataGrid(appointment);

            }

        }

        private void addAppointmenttoDataGrid(Appointment appointment)
        {
            appointmentDataGrid.Rows.Add(
                appointment.Start,
                appointment.End,
                appointment.Title,
                appointment.Type,
                appointment.Location,
                appointment.Description,
                appointment.Contact,
                appointment.ID);
        }

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

        private void deleteApptButton_Click(object sender, EventArgs e)
        {

        }

        private void upCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //CustomerInformationForm customer = new CustomerInformationForm();
            // customer.Show();
        }



        private void apptTaskLabel_Click(object sender, EventArgs e)
        {

        }

        private void createApptButton_Click(object sender, EventArgs e)
        {

            CreateAppointment create = new CreateAppointment();
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
    }
}
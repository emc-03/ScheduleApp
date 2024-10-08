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
    public partial class UpdateAppointmentForm : Form
    {
        private Appointment _appointment;
        //private AppointmentValidator _appointmentValidator; // use for appointmentValidation method

        public event Action<Appointment> UpdatedAppointment;

        public UpdateAppointmentForm(Appointment appointment)
        {

            _appointment = appointment;
            InitializeComponent();
            populateCustomerData();
        }

        private void populateCustomerData()
        {
            if (_appointment != null)
            {
                // Populate the controls with customer data
                updateTitleInput.Text = _appointment.Title;
                updateDescriptionInput.Text = _appointment.Description;
                updateLocationInput.Text = _appointment.Location;
                updateContactInput.Text = _appointment.Contact;
                updateLinkInput.Text = _appointment.URL;
                updateDateTimeSelect.MinDate = _appointment.Start;// TODO needs to select the correct day/month/year 
                updateTypeDropdown.Text = _appointment.Type;
            }
            

        }

        private void UpcustIdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void upCustomerIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void UplnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void uplnLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpfnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void apptTypeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTime_Click(object sender, EventArgs e)
        {

        }



        private void updateButton_Click(object sender, EventArgs e)
        {
            
            _appointment.Title = this.updateTitleInput.Text;
            _appointment.Location = this.updateLocationInput.Text;
            _appointment.Description = this.updateDescriptionInput.Text;
            _appointment.Contact = this.updateContactInput.Text;
            _appointment.URL = this.updateLinkInput.Text;
            _appointment.Start = this.updateStartTimeInput.Value;
            _appointment.End = this.updateEndTimeInput.Value;
            _appointment.Type = this.updateTypeDropdown.Text;
            // call validate appointment - inside 'try block' include lines this.Close();
           
            AppointmentData appointmentData = new AppointmentData();
            appointmentData.Update(_appointment);


            //Loading appointment into appointment list
            


            MessageBox.Show("Appointment successfully updated.");
            //fire off event
            UpdatedAppointment(_appointment);
            this.Close();
            //this is where the catch block goes, to catch any exception thrown by validate appointment and show a messagebox 'validate appointment threw..."
        }

        private void upCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void updateAppt_Load(object sender, EventArgs e)
        {

        }

        private void upHourBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateTitleInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateDescriptionInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateLocationInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateContactInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void createLinkInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateDateTimeSelect_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString))
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                /* 
     {

     using (DataTable dataTable = new DataTable("Appointment"))
     using (MySqlDataReader reader = command.ExecuteReader())
         {
             // Read the results
             while (reader.Read())
             {
                 // Assuming dateTimePicker1 is the first column (index 0)
                 DateTime dateTimeValue = reader.GetDateTime(0);
                 Console.WriteLine("DateTime value: " + dateTimeValue);
             }
         }
     }

 }
 */
            }
            catch (Exception except)
            {
                Console.WriteLine("An error occurred: " + except.Message);
            }

        }

        private void updateStartTimeInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updateEndTimeInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updateTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

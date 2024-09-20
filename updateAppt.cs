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
    public partial class updateAppt : Form
    {
        private Appointment _appointment;
        private Appointment apptToUpdate = new Appointment();

        public updateAppt(Appointment appointment)
        {
            _appointment = appointment;
            apptToUpdate = appointment;
            InitializeComponent();
            populateCustomerData();
        }

        private void populateCustomerData()
        {

            // Populate the controls with customer data

            updateTitleInput.Text = apptToUpdate.Title;
            updateDescriptionInput.Text = apptToUpdate.Description;
            updateLocationInput.Text = apptToUpdate.Location;
            updateContactInput.Text = apptToUpdate.Contact;
            updateLinkInput.Text = apptToUpdate.URL;
            updateDateTimeSelect.MinDate = apptToUpdate.Start;// TODO needs to select the correct day/month/year 
            updateTypeDropdown.Text = apptToUpdate.Type;

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
            AppointmentData appointmentData = new AppointmentData();
            apptToUpdate.Description = this.updateDescriptionInput.Text;

            appointmentData.Update(apptToUpdate);
            MessageBox.Show("Appointment successfully updated.");
            this.Close();
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

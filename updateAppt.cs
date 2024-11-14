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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ScheduleApp
{
    public partial class UpdateAppointmentForm : Form
    {
        TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
        TimeZoneInfo estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        TimeZoneInfo utcTimeZone = TimeZoneInfo.Utc;
        private Appointment _appointment;
        private AppointmentValidator _appointmentValidator;

        public event Action<Appointment> UpdatedAppointment;

        public UpdateAppointmentForm(Appointment appointment, List<Appointment> appointments)
        {
            _appointmentValidator = new AppointmentValidator(appointments);
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
                updateDateTimeSelect.MinDate = _appointment.Start;
                updateApptType.Text = _appointment.Type;
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
            TimeZoneInfo estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            _appointment.Start = TimeZoneInfo.ConvertTime(this.updateStartTimeInput.Value, estTimeZone);
            _appointment.End = TimeZoneInfo.ConvertTime(this.updateEndTimeInput.Value, estTimeZone);
            _appointment.Type = this.updateApptType.Text;

            if (string.IsNullOrEmpty(updateTitleInput.Text))
            {
                MessageBox.Show("Fill in missing feilds.");
                updateTitleInput.Clear();
                updateTitleInput.Focus();
                return;
            }
            else
            {
                _appointment.Title = updateTitleInput.Text;
            }


            if (string.IsNullOrEmpty(updateDescriptionInput.Text))
            {
                MessageBox.Show("Please fill in missing feilds.");
                updateDescriptionInput.Clear();
                updateDescriptionInput.Focus();
                return;
            }

            else
            {
                _appointment.Description = updateDescriptionInput.Text;
            }
            // TODO LOCATION THROWS INCORRECT ERROR -- ALSO IN CREATE FORM 
            if (string.IsNullOrEmpty(updateLocationInput.Text))
            {
                MessageBox.Show("Fill in missing feilds.");
                updateLocationInput.Clear();
                updateLocationInput.Focus();
                return;
            }
            else
            {
                string locationPattern = @"^[a-zA-Z\s\-'.]+$"; // Allows letters, spaces, hyphens, apostrophes, and periods
                if (Regex.IsMatch(updateLocationInput.Text, locationPattern))
                {
                    MessageBox.Show("Invalid location type! Check for typo, numbers are invalid.");

                    updateLocationInput.Clear();
                    updateLocationInput.Focus();
                    return;
                }
                _appointment.Location = updateLocationInput.Text;
            }


            if (string.IsNullOrEmpty(updateContactInput.Text))
            {

                MessageBox.Show("Please fill in missing feilds");
                updateContactInput.Clear();
                updateContactInput.Focus();
                return;
            }
            else
            {
                string contactPattern = @"[a-zA-Z\s\-'.]+$";
                if (!Regex.IsMatch(updateContactInput.Text, contactPattern))
                {
                    MessageBox.Show("Check for typo, numbers are invalid.");

                    updateContactInput.Clear();
                    updateContactInput.Focus();
                    return;
                }

                _appointment.Contact = updateContactInput.Text;
            }

            try
            {
                _appointmentValidator.ValidateAppointment(startTime: _appointment.Start, endTime: _appointment.End);

                AppointmentData appointmentData = new AppointmentData();
                appointmentData.Update(_appointment);

                MessageBox.Show("Appointment successfully updated.");
                //fire off event
                UpdatedAppointment(_appointment);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            updateEndTimeInput.Value = new DateTime(
                updateDateTimeSelect.Value.Year,
                updateDateTimeSelect.Value.Month,
                updateDateTimeSelect.Value.Day,
                updateEndTimeInput.Value.Hour,
                updateEndTimeInput.Value.Minute,
                updateEndTimeInput.Value.Second);

            updateStartTimeInput.Value = new DateTime(
               updateDateTimeSelect.Value.Year,
               updateDateTimeSelect.Value.Month,
               updateDateTimeSelect.Value.Day,
               updateStartTimeInput.Value.Hour,
               updateStartTimeInput.Value.Minute,
               updateStartTimeInput.Value.Second);


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

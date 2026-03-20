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
            assignValuesToDatePickers();
            populateCustomerData();

        }

        private void assignValuesToDatePickers()
        {
            this.updateEndTimeInput.Value = _appointment.End;
            this.updateStartTimeInput.Value = _appointment.Start;
            this.updateDateTimeSelect.Value = _appointment.End;
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

        private void updateButton_Click(object sender, EventArgs e)
        {

            _appointment.Title = this.updateTitleInput.Text.Trim();
            _appointment.Location = this.updateLocationInput.Text.Trim();
            _appointment.Description = this.updateDescriptionInput.Text.Trim();
            _appointment.Contact = this.updateContactInput.Text.Trim();
            _appointment.URL = this.updateLinkInput.Text.Trim();
            _appointment.Type = this.updateApptType.Text.Trim();

           
            try
            {
                DateTime appointmentDate = updateDateTimeSelect.Value;
                DateTime startTime = updateStartTimeInput.Value;
                DateTime endTime = updateEndTimeInput.Value;

                DateTime startTimeDate, endTimeDate;
                Utilities.BuildStartEndDateFromInputs(appointmentDate, startTime, endTime, out startTimeDate, out endTimeDate);

                _appointmentValidator.ValidateAppointmentTime(startTimeDate, endTimeDate);
                _appointment.Start = startTimeDate;
                _appointment.End = endTimeDate;

                _appointmentValidator.ValidateCustomerDetails(_appointment);
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

        private void updateDateTimeSelect_ValueChanged(object sender, EventArgs e) { }
        private void UpcustIdInput_TextChanged(object sender, EventArgs e) { }
        private void upCustomerIDLabel_Click(object sender, EventArgs e) { }
        private void UplnameInput_TextChanged(object sender, EventArgs e) { }
        private void uplnLabel_Click(object sender, EventArgs e) { }
        private void UpfnameInput_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void apptTypeBox_TextChanged(object sender, EventArgs e) { }
        private void dateTime_Click(object sender, EventArgs e) { }
        private void updateAppt_Load(object sender, EventArgs e) { }
        private void upHourBox_TextChanged(object sender, EventArgs e) { }
        private void updateTitleInput_TextChanged(object sender, EventArgs e) { }
        private void updateDescriptionInput_TextChanged(object sender, EventArgs e) { }
        private void updateLocationInput_TextChanged(object sender, EventArgs e) { }
        private void updateContactInput_TextChanged(object sender, EventArgs e) { }
        private void createLinkInput_TextChanged(object sender, EventArgs e) { }
        private void updateStartTimeInput_ValueChanged(object sender, EventArgs e) { }
        private void updateEndTimeInput_ValueChanged(object sender, EventArgs e) { }
        private void updateTypeDropdown_SelectedIndexChanged(object sender, EventArgs e) { }
        private void updateApptType_TextChanged(object sender, EventArgs e) { }

    }
}

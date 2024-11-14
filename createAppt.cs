using ScheduleApp.Database;
using ScheduleApp.models;
using ScheduleApp.Validator;
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
    public partial class CreateAppointmentForm : Form
    {
        private AppointmentData _appointmentData;
        private Customer _customer;
        private User _user;
        private AppointmentValidator _appointmentValidator; // use for validation and use this login in the update appointment form. 
        private CustomerValidator _customerValidation;
        private Appointment _createdAppointment = new Appointment();
        public event Action<Appointment> CreatedAppointment;

        // A method to validate if the appointment is within the next 15 minutes
        private bool IsAppointmentWithin15Minutes(Appointment appointment)
        {
            DateTime currentUtcTime = DateTime.UtcNow;
            DateTime quarterTime = currentUtcTime.AddMinutes(15);

            // Check if the appointment start time is within the next 15 minutes
            return appointment.Start <= quarterTime && appointment.Start >= currentUtcTime;
        }

        // Constructor to accept an Appointment object
        public CreateAppointmentForm(Customer customer, User user)
        {
            //save the customers appointmentlist to the AppointmentValidator class property

            _appointmentData = new AppointmentData();
           // _appointmentValidator = new AppointmentValidator();
            _customerValidation = new CustomerValidator();
            _customer = customer;
            _user = user;
            InitializeComponent();
        }



        private void CreateCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        // TODO adjust validation into validation helper
        private void createApptButton_Click(object sender, EventArgs e)
        {
            _createdAppointment.UserID = _user.ID;
            _createdAppointment.CustomerID = _customer.ID;

            try
            {
                // Validate Title
                if (string.IsNullOrEmpty(createTitleInput.Text))
                {
                    MessageBox.Show("Fill in missing fields.");
                    createTitleInput.Clear();
                    createTitleInput.Focus();
                    return;
                }
                else
                {
                    _createdAppointment.Title = createTitleInput.Text;
                }

                // Validate Description
                if (string.IsNullOrEmpty(createDescriptionInput.Text))
                {
                    MessageBox.Show("Fill in missing fields.");
                    createDescriptionInput.Clear();
                    createDescriptionInput.Focus();
                    return;
                }
                else
                {
                    _createdAppointment.Description = createDescriptionInput.Text;
                }

                // Validate Location
                if (string.IsNullOrEmpty(createLocationInput.Text))
                {
                    MessageBox.Show("Fill in missing fields.");
                    createLocationInput.Clear();
                    createLocationInput.Focus();
                    return;
                }
                else
                {
                    _createdAppointment.Location = createLocationInput.Text;
                }

                // Validate Contact
                if (string.IsNullOrEmpty(createContactInput.Text))
                {
                    MessageBox.Show("Fill in missing fields.");
                    createContactInput.Clear();
                    createContactInput.Focus();
                    return;
                }
                else
                {
                    _createdAppointment.Contact = createContactInput.Text;
                }

                // Validate Type
                if (string.IsNullOrEmpty(createTypeDropDown.Text))
                {
                    MessageBox.Show("Fill in missing fields.");
                    createTypeDropDown.Focus();
                    return;
                }
                else
                {
                    _createdAppointment.Type = createTypeDropDown.Text;
                }

                // Validate URL
                if (string.IsNullOrEmpty(createLinkInput.Text))
                {
                    MessageBox.Show("Fill in missing fields.");
                    createLinkInput.Clear();
                    createLinkInput.Focus();
                    return;
                }
                else
                {
                    _createdAppointment.URL = createLinkInput.Text;
                }

                // Validate Date and Time
                DateTime appointmentDate, startTime, endTime;

                if (createDateTimeSelect.Value == null)
                {
                    MessageBox.Show("Fill in missing fields.");
                    createDateTimeSelect.Focus();
                    return;
                }
                else
                {
                    appointmentDate = createDateTimeSelect.Value;
                }

                if (createStartTimeInput.Value == null)
                {
                    MessageBox.Show("Fill in missing fields.");
                    createStartTimeInput.Focus();
                    return;
                }
                else
                {
                    startTime = createStartTimeInput.Value;
                }

                if (createEndTimeInput.Value == null)
                {
                    MessageBox.Show("Fill in missing fields.");
                    createEndTimeInput.Focus();
                    return;
                }
                else
                {
                    endTime = createEndTimeInput.Value;
                }

                // Combine date and time using Utilities method
                DateTime startTimeDate, endTimeDate;
                Utilities.BuildStartEndDateFromInputs(appointmentDate, startTime, endTime, out startTimeDate, out endTimeDate);

                // Manually validate the time range
                if (startTimeDate >= endTimeDate)
                {
                    MessageBox.Show("Start time must be earlier than end time.");
                    return;
                }

                // Assign the validated start and end times to the appointment
                _createdAppointment.Start = startTimeDate;
                _createdAppointment.End = endTimeDate;

                // Call Add method to save the appointment
                _createdAppointment = _appointmentData.Add(_createdAppointment, _user.Name);

                // Notify user that the appointment was created successfully
                CreatedAppointment(_createdAppointment);
            }
            catch (Exception)
            {
                MessageBox.Show("Appointment failed to save!");
            }

            this.Close();
        }



        private void createIdInput_TextChanged(object sender, EventArgs e)
        {

        }


        private void createDescriptionInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAppointment_Load(object sender, EventArgs e)
        {

        }

        private void createDescriptionLable_Click(object sender, EventArgs e)
        {

        }

        private void createLocationLabel_Click(object sender, EventArgs e)
        {

        }

        private void createLocationInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void createFnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void createLinkLabel_Click(object sender, EventArgs e)
        {

        }

        private void createTitleLable_Click(object sender, EventArgs e)
        {

        }

        private void apptTypeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createDateTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void createDateTimeSelect_ValueChanged(object sender, EventArgs e)
        {

        }

        private void createStartTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void createEndTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void createTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

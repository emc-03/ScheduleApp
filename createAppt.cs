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
        private AppointmentValidator _appointmentValidator; // Use for validation and use this logic in the update appointment form.
        private CustomerValidator _customerValidation;
        private Appointment _createdAppointment;
        public event Action<Appointment> CreatedAppointment;

        // A method to validate if the appointment is within the next 15 minutes
        private bool IsAppointmentWithin15Minutes(Appointment appointment)
        {
            DateTime currentUtcTime = DateTime.UtcNow;
            DateTime quarterTime = currentUtcTime.AddMinutes(15);

            return appointment.Start <= quarterTime && appointment.Start >= currentUtcTime;
        }

        // Constructor to accept an Appointment object
        public CreateAppointmentForm(Customer customer, User user)
        {
            _appointmentData = new AppointmentData();
            _appointmentValidator = new AppointmentValidator()
            {
              Appointment = customerAp
            };
            _customerValidation = new CustomerValidator();
            _customer = customer;
            _user = user;
            _createdAppointment = new Appointment();
            InitializeComponent();
        }

        private void CreateCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // validate and create appointment
        private void ValidateAndCreateAppointment()
        {
            try
            {
                Appointment newAppointment = new Appointment
                {
                    Title = createTitleInput.Text,
                    Description = createDescriptionInput.Text,
                    Location = createLocationInput.Text,
                    Contact = createContactInput.Text,
                    Type = createApptTypeInput.Text,
                    URL = createLinkInput.Text,
                    CustomerID = _customer.ID,
                    UserID = _user.ID
                };

                if (string.IsNullOrWhiteSpace(newAppointment.Title) ||
                    string.IsNullOrWhiteSpace(newAppointment.Description) ||
                    string.IsNullOrWhiteSpace(newAppointment.Location) ||
                    string.IsNullOrWhiteSpace(newAppointment.Contact) ||
                    string.IsNullOrWhiteSpace(newAppointment.Type) ||
                    string.IsNullOrWhiteSpace(newAppointment.URL))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime appointmentDate = createDateTimeSelect.Value;
                DateTime startTime = createStartTimeInput.Value;
                DateTime endTime = createEndTimeInput.Value;

                if (startTime >= endTime)
                {
                    MessageBox.Show("Start time must be earlier than end time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime startTimeDate, endTimeDate;
                Utilities.BuildStartEndDateFromInputs(appointmentDate, startTime, endTime, out startTimeDate, out endTimeDate);

                newAppointment.Start = TimeZoneInfo.ConvertTimeToUtc(startTimeDate);
                newAppointment.End = TimeZoneInfo.ConvertTimeToUtc(endTimeDate);

                var validationResults = _appointmentValidator.ValidateAppointment();
                if (!validationResults.IsValid)
                {
                    MessageBox.Show(string.Join("\n", validationResults.Errors), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsAppointmentWithin15Minutes(newAppointment))
                {
                    MessageBox.Show("The appointment must be within the next 15 minutes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _createdAppointment = _appointmentData.Add(newAppointment, _user.Name);

                CreatedAppointment?.Invoke(_createdAppointment);
                MessageBox.Show("Appointment created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Appointment failed to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createApptButton_Click(object sender, EventArgs e)
        {
            ValidateAndCreateAppointment();
        }

        private void createIdInput_TextChanged(object sender, EventArgs e) { }
        private void createDescriptionInput_TextChanged(object sender, EventArgs e) { }
        private void CreateAppointment_Load(object sender, EventArgs e) { }
        private void createDescriptionLable_Click(object sender, EventArgs e) { }
        private void createLocationLabel_Click(object sender, EventArgs e) { }
        private void createLocationInput_TextChanged(object sender, EventArgs e) { }
        private void createFnameInput_TextChanged(object sender, EventArgs e) { }
        private void createLinkLabel_Click(object sender, EventArgs e) { }
        private void createTitleLable_Click(object sender, EventArgs e) { }
        private void apptTypeBox_TextChanged(object sender, EventArgs e) { }
        private void createDateTimeLabel_Click(object sender, EventArgs e) { }
        private void createDateTimeSelect_ValueChanged(object sender, EventArgs e) { }
        private void createStartTimeLabel_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void createEndTimeLabel_Click(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void createTypeLabel_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void createApptTypeInput_TextChanged(object sender, EventArgs e) { }
    }
}

//namespace ScheduleApp
//{
//    public partial class CreateAppointmentForm : Form
//    {
//        private AppointmentData _appointmentData;
//        private Customer _customer;
//        private User _user;
//        private AppointmentValidator _appointmentValidator; // use for validation and use this login in the update appointment form. 
//        private CustomerValidator _customerValidation;
//        private Appointment _createdAppointment = new Appointment();
//        public event Action<Appointment> CreatedAppointment;

//        // A method to validate if the appointment is within the next 15 minutes
//        private bool IsAppointmentWithin15Minutes(Appointment appointment)
//        {
//            DateTime currentUtcTime = DateTime.UtcNow;
//            DateTime quarterTime = currentUtcTime.AddMinutes(15);

//            // Check if the appointment start time is within the next 15 minutes
//            return appointment.Start <= quarterTime && appointment.Start >= currentUtcTime;
//        }

//        // Constructor to accept an Appointment object
//        public CreateAppointmentForm(Customer customer, User user)
//        {
//            //save the customers appointmentlist to the AppointmentValidator class property
//            _appointmentData = new AppointmentData();
//            //_appointmentValidator = new AppointmentValidator();
//            _customerValidation = new CustomerValidator();
//            _customer = customer;
//            _user = user;
//            InitializeComponent();
//        }
//        private void createApptButton_Click(object sender, EventArgs e) 
//        {

//        }

//        private void CreateCancelButton_Click(object sender, EventArgs e)
//        {
//            this.Close();

//        }

//        private void createIdInput_TextChanged(object sender, EventArgs e) { }
//        private void createDescriptionInput_TextChanged(object sender, EventArgs e) { }
//        private void CreateAppointment_Load(object sender, EventArgs e) { }
//        private void createDescriptionLable_Click(object sender, EventArgs e) { }
//        private void createLocationLabel_Click(object sender, EventArgs e) { }
//        private void createLocationInput_TextChanged(object sender, EventArgs e) { }
//        private void createFnameInput_TextChanged(object sender, EventArgs e) { }
//        private void createLinkLabel_Click(object sender, EventArgs e) { }
//        private void createTitleLable_Click(object sender, EventArgs e) { }
//        private void apptTypeBox_TextChanged(object sender, EventArgs e) { }
//        private void createDateTimeLabel_Click(object sender, EventArgs e) { }
//        private void createDateTimeSelect_ValueChanged(object sender, EventArgs e) { }
//        private void createStartTimeLabel_Click(object sender, EventArgs e) { }
//        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
//        private void createEndTimeLabel_Click(object sender, EventArgs e) { }
//        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
//        private void createTypeLabel_Click(object sender, EventArgs e) { }
//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
//        private void createApptTypeInput_TextChanged(object sender, EventArgs e) { }



//    }
//    }

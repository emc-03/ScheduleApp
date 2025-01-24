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
        private Appointment _createdAppointment;
        public event Action<Appointment> CreatedAppointment;
        

        // Constructor to accept an Appointment object
        public CreateAppointmentForm(Customer customer, User user)
        {
            _appointmentData = new AppointmentData();
            _appointmentValidator = new AppointmentValidator(customer.AppointmentList);
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
                    Title = createTitleInput.Text.Trim(),
                    Description = createDescriptionInput.Text.Trim(),
                    Location = createLocationInput.Text.Trim(),
                    Contact = createContactInput.Text.Trim(),
                    Type = createApptTypeInput.Text.Trim(),
                    URL = createLinkInput.Text.Trim(),
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


                DateTime startTimeDate, endTimeDate;
                Utilities.BuildStartEndDateFromInputs(appointmentDate, startTime, endTime, out startTimeDate, out endTimeDate);

                _appointmentValidator.ValidateAppointmentTime(startTimeDate, endTimeDate);
                newAppointment.Start = startTimeDate;
                newAppointment.End = endTimeDate;
                _appointmentValidator.ValidateCustomerDetails(newAppointment);
                // grabs the userId and the apptId
                _createdAppointment = _appointmentData.Add(newAppointment, _user.Name);

                CreatedAppointment(_createdAppointment);
                MessageBox.Show("Appointment created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void createApptButton_Click(object sender, EventArgs e)
        {

            ValidateAndCreateAppointment();
        }
        private void createDateTimeSelect_ValueChanged(object sender, EventArgs e) { }
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
        private void createStartTimeLabel_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void createEndTimeLabel_Click(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void createTypeLabel_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void createApptTypeInput_TextChanged(object sender, EventArgs e) { }
    }
}



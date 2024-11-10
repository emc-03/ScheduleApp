using ScheduleApp.Database;
using ScheduleApp.models;
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
        //private AppointmentValidator _appointmentValidator; // use for validation and use this login in the update appointment form. 
        private Appointment _createdAppointment = new Appointment();
        public event Action<Appointment> CreatedAppointment;

        // Constructor to accept an Appointment object
        public CreateAppointmentForm(Customer customer, User user)
        {
            //save the customers appointmentlist to the AppointmentValidator class property
            
            _appointmentData = new AppointmentData();
            _customer = customer;
            _user = user;
            InitializeComponent();
        }



        private void CreateCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void createApptButton_Click(object sender, EventArgs e)
        {

            _createdAppointment.UserID = _user.ID;
            _createdAppointment.CustomerID = _customer.ID;

            try
            {

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

                if (string.IsNullOrEmpty(createDescriptionInput.Text))

                {
                    MessageBox.Show("Fill in missing fields.");
                    createLocationInput.Clear();
                    createLocationInput.Focus();
                    return;
                }
                else
                {
                    _createdAppointment.Description = createDescriptionInput.Text;
                }
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
                if (string.IsNullOrEmpty(createTypeDropDown.Text))

                {
                    MessageBox.Show("Fill in missing fields.");
                    //createTypeDropDown.Clear();
                    createTypeDropDown.Focus();
                    return;
                }
                else
                {
                    _createdAppointment.Type = createTypeDropDown.Text;
                }

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


                //TODO - FIXME - adjust to handle datetime and hour/mins
                /*
                if (string.IsNullOrEmpty(createDateTimeSelect.Text))

                {
                    MessageBox.Show("Fill in missing fields.");
                    createDateTimeSelect.Clear();
                    createDateTimeSelect.Focus();
                    return;
                }
                else
                {
                    appointment.Contact = createDateTimeSelect.Text;
                }
                if (string.IsNullOrEmpty(createStartTimeInput.Text))

                {
                    MessageBox.Show("Fill in missing fields.");
                    createStartTimeInput.Clear();
                    createStartTimeInput.Focus();
                    return;
                }
                else
                {
                    appointment.Contact = createStartTimeInput.Text;
                }

                if (string.IsNullOrEmpty(createEndTimeInput.Text))

                {
                    MessageBox.Show("Fill in missing fields.");
                    createEndTimeInput.Clear();
                    createEndTimeInput.Focus();
                    return;
                }
                else
                {
                    appointment.Contact = createEndTimeInput.Text;
                }

    */          
                // call AppointmentValidator.ValidateAppointment
                _createdAppointment = _appointmentData.Add(_createdAppointment, _user.Name);
                
                CreatedAppointment(_createdAppointment);
            }
            catch (Exception _) { MessageBox.Show("Appointment failed to save!"); }
            
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

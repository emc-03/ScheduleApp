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
    public partial class CreateAppointment : Form
    {
        private AppointmentData _appointmentData;

        public CreateAppointment()
        {
            _appointmentData = new AppointmentData();
            InitializeComponent();
        }

        

        private void CreateCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void createApptButton_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            

            if (string.IsNullOrEmpty(createTitleInput.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                createTitleInput.Clear();
                createTitleInput.Focus();
                return;
            }
            else
            {
                appointment.Contact = createTitleInput.Text;
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
                appointment.Contact = createDescriptionInput.Text;
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
                appointment.Contact = createLocationInput.Text;
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
                appointment.Contact = createContactInput.Text;
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
            _appointmentData.Add(appointment);
            

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

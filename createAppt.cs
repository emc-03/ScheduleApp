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
            // add in condition to input each field from form
            _appointmentData.Add(appointment);
            

        }
    }
}

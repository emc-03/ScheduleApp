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
    public partial class CreateByReportMain : Form
    {
        private AppointmentData _appointmentData = new AppointmentData();
        private List<Appointment> _appointments;
        private Dictionary<string, string> _userIdDictionary = new Dictionary<string, string>(); 
        

        public CreateByReportMain()
        {
            InitializeComponent();
        }

        public string loadDatatoCreateByReport(User userID)
        {
            // retrieve all appointments from db
            _appointments = _appointmentData.FindAllAppt();

            // validate and populate userId Dictionary 
            foreach (var appointment in _appointments)
            {
                if(appointment.UserID > -1) // change to 0 ?  needs to be greater then 0 .. but if the userId is 0 ? 
                {
                    //checks to see if the userId is in the dictionary and ensures it was not duplicated
                    if(!_userIdDictionary.ContainsKey(appointment.UserID.ToString()))
                    {
                        _userIdDictionary[appointment.UserID.ToString()] = string.Empty;
                    }
                }
            }

            UserData userData = new UserData();
            foreach (var userIdKey in _userIdDictionary.Keys.ToList())
            {
                //check for get function in UserData
                string username = userData.GetUserNamebyID(int.Parse(userIdKey));
                _userIdDictionary[userIdKey = username]; 
                // update the dictionary with the username.... needs to be used in the datagrid
            }



        }

        public void populateCreateByDataGrid()
        {
            dataGridCreateByReport.Columns.Clear();

            dataGridCreateByReport.Columns.Add("Type", "Username");
            dataGridCreateByReport.Columns.Add("Type", "Title");
            dataGridCreateByReport.Columns.Add("Type", "Description");
            dataGridCreateByReport.Columns.Add("Type", "Appointment Date");
            dataGridCreateByReport.Columns.Add("Type", "Appointment Time");
            dataGridCreateByReport.Columns.Add("Type", "Location");
        }
        private void exitReport_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridCreateByReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

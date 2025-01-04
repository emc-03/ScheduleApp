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
        private Dictionary<int, string> _userIdDictionary = new Dictionary<int, string>();


        public CreateByReportMain()
        {
            InitializeComponent();
            loadDatatoCreateByReport();
            populateCreateByDataGrid();
        }

        public void loadDatatoCreateByReport()
        {
            // retrieve all appointments from db
            // use lambda in this method - each of the report methods needs to have a lambda expression
            _appointments = _appointmentData.FindAllAppt();

            // validate and populate userId Dictionary 
            foreach (var appointment in _appointments)
            {
                if (appointment.UserID > -1)
                {
                    //checks to see if the userId is in the dictionary and ensures it was not duplicated
                    if (!_userIdDictionary.ContainsKey(appointment.UserID))
                    {
                        _userIdDictionary[appointment.UserID] = string.Empty;
                    }
                }
            }
            // populate dictionary with usernames 
            UserData userData = new UserData();
            _userIdDictionary.Keys.ToList().ForEach(key =>
            {
                //check for get function in UserData
                _userIdDictionary[key] = userData.GetUserNameById(key);
                // update the dictionary with the username.... needs to be used in the datagrid
            }
            );


        }

        public void populateCreateByDataGrid()
        {
            dataGridCreateByReport.Columns.Clear();

            dataGridCreateByReport.Columns.Add("Username", "Username");
            dataGridCreateByReport.Columns.Add("Title", "Title");
            dataGridCreateByReport.Columns.Add("Description", "Description");
            dataGridCreateByReport.Columns.Add("AppointmentDate", "Appointment Date");
            dataGridCreateByReport.Columns.Add("AppointmentTime", "Appointment Time");
            dataGridCreateByReport.Columns.Add("Location", "Location");

            // list of rows
            var rows = new List<object[]>();

            // add values and populate rows 
            foreach (var appointment in _appointments)
            {
                if (_userIdDictionary.TryGetValue(appointment.UserID, out var username))
                {
                    rows.Add(new object[]
                        {
                            username,
                            appointment.Title,
                            appointment.Description,
                            appointment.Start.ToString("MM/yyyy"),
                            appointment.Start.ToString("hh:mm"),
                            appointment.Location
                        });
                }

                // populate datagrid
                foreach (var row in rows)
                {
                    dataGridCreateByReport.Rows.Add(row);
                }
            }

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

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
    public partial class UserReportMain : Form
    {

        private List<Appointment> _appointmentsUserReport;

        public UserReportMain()
        {
            InitializeComponent();
            LoadAppointmentData();
            BindDataToGrid();

        }

        private void LoadAppointmentData()
        {
            _appointmentsUserReport = new List<Appointment>;
            {
                //fetch appointments from DB 
            }

        }

        private void BindDataToGrid()
        { }

        private void UserReportMain_Load(object sender, EventArgs e)
        {

        }

        private void userReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

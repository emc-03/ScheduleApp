using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp.Reports
{
    class ReportHelper
    {
        //TODO BELOW 
        //Create a function that allows users to generate the three reports listed using collection classes, incorporating a lambda expression into the code for each of the following reports:
        // DataGridView - how to display data ? 
        // Appointment Type Values ? 
        //•    the number of appointment types by month

        //•    the schedule for each user

        //•    one additional report of your choice

        // have a collection of Appointment and User objects

        //useReportViewer
        public void GenerateReportforUser()
        {
            // create and bind DataSet to the DataTable
            // Use User and Appointment List - to retreive data

            //var typesByMonth = GetAppointmentTypesByMonth(appointments);
            //var schedules = GetScheduleForEachUser(users, appointments);
           // var appointmentsByDayOfWeek = GetAppointmentsByDayOfWeek(appointments);
        }

        public void GenerateReportByMonth()
        { 
        }

        public void GenerateReportByCreateDate()
        {
        }

    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScheduleApp
{
    public static class Utilities 
    {
        public static void BuildStartEndDateFromInputs(
            //inputs
            DateTime appointmentDate, 
            DateTime startTime, 
            DateTime endTime, 
            //outputs
            out DateTime startTimeDate, 
            out DateTime endTimeDate)
        {
            startTimeDate = new DateTime(
                //date input from user form
                appointmentDate.Year,
                appointmentDate.Month,
                appointmentDate.Day,
                //start time input from user
                startTime.Hour,
                startTime.Minute,
                startTime.Second);

            endTimeDate = new DateTime(
                //date input from user form
                appointmentDate.Year,
                appointmentDate.Month,
                appointmentDate.Day,
                //end time input from user
                endTime.Hour,
                endTime.Minute,
                endTime.Second);
           
        }

    }
 
}

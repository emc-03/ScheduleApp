using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleApp.Database;
using ScheduleApp.models;
using System.Windows.Forms;

namespace ScheduleApp.models
{


    public class AppointmentValidator
    {
        private readonly TimeSpan _timeRangeStart = new TimeSpan(9, 0, 0); // 9 AM
        private readonly TimeSpan _timeRangeEnd = new TimeSpan(17, 0, 0);  // 5 PM
        private TimeZoneInfo estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

        private List<Appointment> _appointments = new List<Appointment>();

        public AppointmentValidator(List<Appointment> appointments)
        {
            _appointments = appointments;

        }
        public void ValidateAppointment(DateTime userStartTime, DateTime userEndTime)
            {
       
            DateTime startEST = TimeZoneInfo.ConvertTime(userStartTime, estTimeZone);
            DateTime endEST = TimeZoneInfo.ConvertTime(userEndTime, estTimeZone);
            bool isNotWithinTimeRange = !isWithinTimeRange(startEST, endEST);
            // Check if within business hours
            if(isNotWithinTimeRange)
            {
                throw new Exception("Error Appointment must be between 9 AM - 5 PM EST.");
            }

            // Check if in working week
            if (!isWithinWorkWeek(startEST))
            {
                throw new Exception("Error: Appointment is not within the work week.");
            }

            // Check for overlapping appointments >> also needs to check specific date, including timeframe
            if (isStartTimeAfterEndTime(startEST, endEST))
            {
                throw new Exception("Error: Appointment's start time is after the end time.");
            }

            //Validate that there's not a conflicting appointment
            if (appointmentConflictExists(startEST, endEST))
            {
                throw new Exception("Error: Appointment overlaps, existing appointment found.");
            }
        }
        // Check if the appointment is within 9-5 range
        private bool isWithinTimeRange(DateTime estStart, DateTime estEnd)
        {
            // Ensure the appointment is scheduled within range
            int startCompareResult = _timeRangeStart.CompareTo(estStart.TimeOfDay);
            int endCompareResult = _timeRangeEnd.CompareTo(estEnd.TimeOfDay);
            bool startIsValid = startCompareResult <= 0;
            bool endIsValid = endCompareResult >= 0;

            return startIsValid && endIsValid;

        }

        private bool isWithinWorkWeek(DateTime apptDate)
        {
            // Ensure the appointment is scheduled M-F
            return apptDate.DayOfWeek != DayOfWeek.Saturday && apptDate.DayOfWeek != DayOfWeek.Sunday;
        }


        private bool isStartTimeAfterEndTime(DateTime startTime, DateTime endTime)

        {
            if (startTime > endTime)

            {
                return true;
            }
            return false;
        }


        public bool appointmentConflictExists(DateTime startTime, DateTime endTime)

        {
            foreach (var existingAppointment in _appointments)
            {
                // Check if the new appointment's start time is within an existing appointment's time range
                if (startTime >= existingAppointment.Start && startTime <= existingAppointment.End)
                {
                    return true; // Conflict found with start time
                }

                // Check if the new appointment's end time is within an existing appointment's time range
                if (endTime >= existingAppointment.Start && endTime <= existingAppointment.End)
                {
                    return true; // Conflict found with end time
                }

                // Check if the new appointment fully overlaps with an existing appointment
                if (startTime <= existingAppointment.Start && endTime >= existingAppointment.End)
                {
                    return true; // Conflict found with full overlap
                }
            }

            // No conflicts found
            return false;
        }

       
    }

}




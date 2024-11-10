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


    //try - catch - where Validatemethod is called
    // create an instance of this class in create & update forms
    public class AppointmentValidator
    {
        private readonly TimeSpan _timeRangeStart = new TimeSpan(9, 0, 0); // 9 AM
        private readonly TimeSpan _timeRangeEnd = new TimeSpan(17, 0, 0);  // 5 PM

        private List<Appointment> _appointments = new List<Appointment>();

        public AppointmentValidator(List<Appointment> appointments)
        {
            _appointments = appointments;

        }


        public void ValidateAppointment(DateTime startTime, DateTime endTime)
        {


            // Check if within business hours
            if (!isWithinTimeRange(startTime, endTime))
            {
                throw new Exception("Error Appointment must be between 9 AM - 5 PM EST.");
            }

            // Check if in working week
            if (!isWithinWorkWeek(startTime))
            {
                throw new Exception("Error: Appointment is not within the work week.");
            }

            // Check for overlapping appointments >> also needs to check specific date - can't just be time frame
            if (isStartTimeAfterEndTime(startTime, endTime))
            { 
                throw new Exception("Error: Appointment's start time is after the end time.");
            }

            //Validate that there's not a conflicting appointment
            if (appointmentConflictExists(startTime, endTime))
            { 

            }


        }





        // Check if the appointment is within 9-5 range
        private bool isWithinTimeRange(DateTime estStart, DateTime estEnd)
        {
            // Ensure the appointment is scheduled within range
            return estStart.TimeOfDay >= _timeRangeStart && estEnd.TimeOfDay <= _timeRangeEnd; //
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
            throw new NotImplementedException();

            foreach (var existingAppointment in _appointments)

            {
                //check if the appointments start time is inbetween
                if (startTime > existingAppointment.Start
                    && startTime < existingAppointment.End)
                {
                    // conflicts found, no conflicts found return false
                    return true;
                }
                return false;

            }
            //foreach over the appointments list
            //is the startTime inbetween the start and end for the current appointment 
            // if YES - return true 
            // is the endTime inbetween the start and end for the current appointment 
            // if YES -return true
            // if the loop completes without any conflicts then return false
        }

    }
     
    
}

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
            private readonly TimeSpan timeRangeStart = new TimeSpan(9, 0, 0); // 9 AM
            private readonly TimeSpan timeRangeEnd = new TimeSpan(17, 0, 0);  // 5 PM
            // this will convert to EST - allow for user identified timezone? 
            private readonly TimeZoneInfo estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            private List<Appointment> appointments = new List<Appointment>();

            // Schedule a new appointment
            // Call method before userinput to update datagridview - and any changes from user 
            // include this call in 'try - block'

            public void ValidateAppointment(DateTime startTime, DateTime endTime)
            {
                // Convert to EST if required
                DateTime estStart = TimeZoneInfo.ConvertTime(startTime, estTimeZone);
                DateTime estEnd = TimeZoneInfo.ConvertTime(endTime, estTimeZone);

                // Check if within business hours
                if (!isWithinTimeRange(estStart, estEnd))
                {
                    throw new Exception("Error ... ");
                   
                    // "Error: Appointment must be between 9 AM - 5 PM.";
                }

                // Check for overlapping appointments
                if (isOverlapping(estStart, estEnd))
                {
                   //"Error: Appointment overlaps with an existing appointment.";
                }

                // Add the new appointment if valid
                appointments.Add(new Appointment { Start = estStart, End = estEnd });
                //"Appointment scheduled successfully.";
            }




            // Check if the appointment is within 9-5 range
            private bool isWithinTimeRange(DateTime startTime, DateTime endTime)
            {
                // Ensure the appointment is scheduled within range
                return startTime.TimeOfDay >= timeRangeStart && endTime.TimeOfDay <= timeRangeEnd;
            }

            // Check if the appointment overlaps 
            private bool isOverlapping(DateTime startTime, DateTime endTime)
            {
                foreach (var appointment in appointments)
                {
                    if ((startTime < appointment.End) && (endTime > appointment.Start))
                    {
                        return true; 
                    }
                }
                return false;
            }
        }
    
}

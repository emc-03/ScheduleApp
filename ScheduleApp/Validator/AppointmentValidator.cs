using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleApp.Database;
using ScheduleApp.models;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        public void ValidateAppointmentTime(DateTime userStartTime, DateTime userEndTime)
        {
            DateTime startEST = TimeZoneInfo.ConvertTime(userStartTime, estTimeZone);
            DateTime endEST = TimeZoneInfo.ConvertTime(userEndTime, estTimeZone);
            bool isNotWithinTimeRange = !isAppointmentWithinRange(startEST, endEST);
            // Check if within business hours
            if (isNotWithinTimeRange)
            {
                throw new Exception("Error Appointment must be between 9 AM - 5 PM EST.");
            }

            // Check if within working week
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
        private bool isAppointmentWithinRange(DateTime estStart, DateTime estEnd)
        {
            return isTimeWithinRange(estStart) && isTimeWithinRange(estEnd);
        }

        private bool isTimeWithinRange(DateTime time)
        {
            int startCompareResult = _timeRangeStart.CompareTo(time.TimeOfDay);
            int endCompareResult = _timeRangeEnd.CompareTo(time.TimeOfDay);
            bool timeAfterStart = startCompareResult <= 0;
            bool timeBeforeEnd = endCompareResult >= 0;

            return timeAfterStart && timeBeforeEnd;
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

        public bool IsValidTitle(string title)
        {
            string titlePattern = @"^[a-zA-Z\s]+$";
            return !string.IsNullOrWhiteSpace(title) &&
                   Regex.IsMatch(title, titlePattern) &&
                   title.Length >= 2 && title.Length <= 25;
        }
        public bool IsValidDescriptionInput(string description)
        {
            string descriptionPattern = @"^[a-zA-Z0-9\s,.-]+$";
            return !string.IsNullOrWhiteSpace(description) &&
                   Regex.IsMatch(description, descriptionPattern) &&
                   description.Length >= 2 && description.Length <= 100;

        }
        public bool IsValidLocation(string location)
        {
            string locationPattern = @"^[a-zA-Z\s]+$";
            return !string.IsNullOrWhiteSpace(location) &&
                   Regex.IsMatch(location, locationPattern) &&
                   location.Length >= 2 && location.Length <= 50;
        }
        public bool IsValidContact(string contact)
        {
            string contactPattern = @"^[a-zA-Z0-9\s,.-]+$";
            return !string.IsNullOrWhiteSpace(contact) &&
                   Regex.IsMatch(contact, contactPattern) &&
                   contact.Length >= 2 && contact.Length <= 50;
        }
        public bool IsValidType(string type)
        {
            string typePattern = @"^[a-zA-Z\s]+$";
            return !string.IsNullOrWhiteSpace(type) &&
                   Regex.IsMatch(type, typePattern) &&
                   type.Length >= 2 && type.Length <= 25;
        }
        public bool IsValidURL(string url)
        {
            string urlPattern = @"^[a-zA-Z0-9\s,.-]+$";
            return !string.IsNullOrWhiteSpace(url) &&
                   Regex.IsMatch(url, urlPattern) &&
                   url.Length >= 2 && url.Length <= 50;
        }

        public bool ValidateCustomerDetails(Appointment apptValid)
        {
            if (!IsValidTitle(apptValid.Title)) throw new Exception("Invalid Title, only letters or spaces.");
            if (!IsValidDescriptionInput(apptValid.Description)) throw new Exception("Invalid description, must be less than 100 characters.");
            if (!IsValidLocation(apptValid.Location)) throw new Exception("Invalid Location, only letters or spaces.");
            if (!IsValidContact(apptValid.Contact)) throw new Exception("Invalid Contact, only letters or spaces.");
            if (!IsValidType(apptValid.Type)) throw new Exception("Invalid Type, only letters or spaces.");
            if (!IsValidURL(apptValid.URL)) throw new Exception("Invalid URL, must be less than 50 characters.");

            return true; // all validation passed 
        }

    }

}




using System;

namespace ScheduleApp.Core.Models
{
    public class Appointment
    {
        private int _appointmentID;
        private int _customerID;
        private int _userID = -1;
        private string _title;
        private string _description;
        private string _location;
        private string _contact;
        private DateTime _start;
        private DateTime _end;
        private string _type;
        private string _url;
        private string _createdBy;

        public int AppointmentID { get { return _appointmentID; } set { _appointmentID = value; } }
        public int CustomerID { get { return _customerID; } set { _customerID = value; } }
        public int UserID { get { return _userID; } set { _userID = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Location { get { return _location; } set { _location = value; } }
        public string Contact { get { return _contact; } set { _contact = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public string URL { get { return _url; } set { _url = value; } }
        public DateTime Start { get { return _start; } set { _start = value; } }
        public DateTime End { get { return _end; } set { _end = value; } }
        public string CreatedBy { get { return _createdBy; } set { _createdBy = value; } }
    }
}

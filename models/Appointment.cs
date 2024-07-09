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
   public class Appointment
    {
        private int _id; 
        private int _customerID;
        private int _userID;
        private string _title;
        private string _description;
        private string _location;
        private string _contact;
        private DateTime _start;
        private DateTime _end;
        private string _type;
        private string _url;
        

        public int ID { get { return _id; } set { _id = value; } }
        public int CustomerID { get { return _customerID; } set { _customerID = value; } }
        public int UserID { get { return _userID; } set { _userID = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Location { get { return _location; } set { _location = value; } }
        public string Contact { get { return _contact; } set { _contact = value; } }
        public DateTime Start { get { return _start; } set { _start = value; } }
        public DateTime End { get { return _end; } set { _end = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public string URL { get { return _url; } set { _url = value; } }

    }

}

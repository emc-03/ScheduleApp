using ScheduleApp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp
{
    
    public class Customer
    {

        private int id;
        private bool isActive;
        private string firstName;
        private string lastName;
        private Address address = new Address();
        private List<Appointment> appointments = new List<Appointment>();


        public int ID { get { return id; } set { id = value; } }
        public bool IsActive { get { return isActive; } set { isActive = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public Address Address { get { return address; } set { address = value; } }
        public List<Appointment> AppointmentList { get { return appointments; } set { appointments = value; } }


    }

    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }


}
 
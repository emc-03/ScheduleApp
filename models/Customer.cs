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
        private List<Appointments> appointments = new List<Appointments>();


        public int ID { get { return id; } set { id = value; } }
        public bool IsActive { get { return isActive; } set { isActive = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public Address Address { get { return address; } set { address = value; } }
        public List<Appointments> Appointments { get { return appointments; } set { appointments = value; } }


    }
    public class Address
    {
        private int id;
        private string address1;
        private string address2;
        private string postalCode;
        private string phoneNumber;
        private City city = new City();

        public int ID { get { return id; } set { id = value; } }
        public string Address1 { get { return address1; } set { address1 = value; } }
        public string Address2 { get { return address2; } set { address2 = value; } }
        public string PostalCode { get { return postalCode; } set { postalCode = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public City City { get { return city; } set { city = value; } }
    }

    public class Appointments
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
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp.models
{
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp.models
{
    public class City
    {
        private int id;
        private string name;
        private Country country;

        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Country Country { get { return country; } set { country = value; } }

    }
}

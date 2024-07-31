using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp
{
    class User
    {

        private int _Id;
        private string _name;
        private string _password;
        private bool _isActive;
        
        public int ID { get { return _Id; } set { _Id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Password { get { return _password;  } set { _password = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

                          
    }
}

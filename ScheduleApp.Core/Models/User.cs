namespace ScheduleApp.Core.Models
{
    public class User
    {
        private int _Id = -1;
        private string _name;
        private string _password;
        private bool _isActive;

        public int ID { get { return _Id; } set { _Id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
    }
}

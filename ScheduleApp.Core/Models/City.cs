namespace ScheduleApp.Core.Models
{
    public class City
    {
        private int id = -1;
        private string name;
        private Country country = new Country();

        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Country Country { get { return country; } set { country = value; } }
    }
}

namespace ScheduleApp.Core.Models
{
    public class Country
    {
        private int id = -1;
        private string name;

        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
    }
}

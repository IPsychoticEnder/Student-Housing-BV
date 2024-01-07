using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV.Classes.Tasks
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, bool> DueDates { get; set; }
        public User UserInCharge { get; set; }

        public Task(string name, string description, Dictionary<string, bool> dueDates, User userInCharge)
        {
            Name = name;
            Description = description;
            DueDates = dueDates;
            UserInCharge = userInCharge;
        }
    }
}

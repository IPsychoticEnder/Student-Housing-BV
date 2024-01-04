

namespace Student_Housing_BV.Classes.Tasks
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, bool> DueDates { get; set; }

        public Task(string name, string description, Dictionary<string, bool> dueDates)
        {
            Name = name;
            Description = description;
            DueDates = dueDates;
        }
    }
}

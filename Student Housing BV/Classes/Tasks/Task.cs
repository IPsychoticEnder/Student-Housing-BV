

namespace Student_Housing_BV.Classes.Tasks
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Task(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}

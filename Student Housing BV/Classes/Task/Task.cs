using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV.Classes.Task
{
    public class Task
    {
        public string name { get; set; }
        public string description { get; set; }
        public List<string> tasakDate { get; set; }
        public User userInCharge { get; set; }
        public bool isComplete { get; set; }


        public Task(string name, string description, List<string> tasakDate, User userInCharge, bool isComplete)
        {
            this.name = name;
            this.description = description;
            this.tasakDate = tasakDate;
            this.userInCharge = userInCharge;
            this.isComplete = isComplete;
        }
    }
}

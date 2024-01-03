using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_BV.Classes
{
    public class Task
    {
        public string name {  get; set; }
        public string description { get; set; }
        public string[] tasakDate { get; set; }
        public User userInCharge { get; set; }
        public bool isComplete { get; set; }


        public Task(string name, string description, string[] tasakDate, User userInCharge, bool isComplete)
        {
            this.name = name;
            this.description = description;
            this.tasakDate = tasakDate;
            this.userInCharge = userInCharge;
            this.isComplete = isComplete;
        }
    }
}

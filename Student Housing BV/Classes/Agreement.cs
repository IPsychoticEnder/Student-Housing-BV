using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_BV.Classes
{
    internal class Agreement
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Agreement(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}

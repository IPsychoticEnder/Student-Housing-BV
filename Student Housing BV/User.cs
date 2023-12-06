using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_BV
{
    public class User
    {
        public string userName {  get; set; }
        public int userID { get; set; }
        public string password { get; set; }
        public bool isAdmin { get; set; }

        public User(string userName, int userID, string password, bool isAdmin) 
        {
            this.userName = userName;
            this.userID = userID;
            this.password = password;
            this.isAdmin = isAdmin;
        }
    }
}

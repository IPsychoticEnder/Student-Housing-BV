using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_BV.Classes
{
    public class User
    {
        public string userName { get; private set; }
        public int userID { get; private set; }
        public string password { get; private set; }
        public bool isAdmin { get; private set; }

        public User(string userName, int userID, string password, bool isAdmin)
        {
            this.userName = userName;
            this.userID = userID;
            this.password = password;
            this.isAdmin = isAdmin;
        }

        public override string ToString()
        {
            if (this.userID < 10)
            {
                return $"00{this.userID} | {this.userName} | {this.isAdmin}";
            }
            else if (this.userID < 100)
            {
                return $"0{this.userID} | {this.userName} | {this.isAdmin}";
            }
            else
            {
                return $"{this.userID} | {this.userName} | {this.isAdmin}";
            }
        }
    }
}

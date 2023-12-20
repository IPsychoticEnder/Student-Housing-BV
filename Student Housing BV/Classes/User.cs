using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_BV.Classes
{
    public class User
    {
        public string UserName { get; set; }
        public int UserID { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public User(string userName, int userID, string password, bool isAdmin)
        {
            this.UserName = userName;
            this.UserID = userID;
            this.Password = password;
            this.IsAdmin = isAdmin;
        }

        public override string ToString()
        {
            return $"{this.UserName}";
        }
    }
}

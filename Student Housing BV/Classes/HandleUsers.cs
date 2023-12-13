using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_BV.Classes
{
    internal class HandleUsers
    {
        public List<User> users { get; private set; }

        public HandleUsers()
        {
            users = new List<User>();
            User admin = new User("admin", 000, "ADMIN", true);
            users.Add(admin);
        }

        public void AddUser(string userName, string password, bool isAdmin)
        {
            int userID = users.Last().userID + 1;
            User newUser = new User(userName, userID, password, isAdmin);
            users.Add(newUser);
        }

        public void RemoveUser(string userName, int userID)
        {
            foreach (User user in users)
            {
                if (userName.Equals(user.userName) && userID == user.userID)
                {
                    users.Remove(user);
                }
            }
        }

        public User ValidateUser(User toBeValidatedUser)
        {
            foreach (User user in users)
            {
                if (toBeValidatedUser.userID == user.userID && toBeValidatedUser.password == user.password)
                {
                    return user;
                }
            }
            return null;
        }

        
    }
}

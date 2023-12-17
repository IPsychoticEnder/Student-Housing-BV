using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Housing_BV.Classes
{
    public class HandleUsers
    {
        public List<User> users { get; private set; }

        public string filePath { get; private set; }

        public HandleUsers()
        {
            users = new List<User>();

            string relativeFilepath = "\\Data\\Json\\Users.json";
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            while (!currentDirectory.EndsWith("\\Student Housing BV"))
            {
                currentDirectory = Directory.GetParent(currentDirectory).FullName;
            }

            this.filePath = $"{currentDirectory}{relativeFilepath}";
            ReadFromJson();
        }

        public void AddUser(string userName, string password, bool isAdmin)
        {
            int userID = users.Last().userID + 1;
            User newUser = new User(userName, userID, password, isAdmin);
            users.Add(newUser);
            WriteToJson();
        }

        public void RemoveUser(User toBeRemvedUser)
        {
            if (users.Contains(toBeRemvedUser))
            {
                users.Remove(toBeRemvedUser);
            }
            int queueUserID = 0;
            foreach (User user in users)
            {
                user.userID = queueUserID;
                queueUserID++;
            }
            WriteToJson();
        }

        public void EditUser(User editedUser)
        {
            foreach(User user in users)
            {
                if (user.userID == editedUser.userID)
                {
                    user.userName =  editedUser.userName;
                    user.password = editedUser.password;
                    user.isAdmin = editedUser.isAdmin;
                }
            }
            WriteToJson();
        }

        public User ValidateUser(User toBeValidatedUser)
        {
            foreach (User user in users)
            {
                if (toBeValidatedUser.userName == user.userName && toBeValidatedUser.password == user.password)
                {
                    return user;
                }
            }
            return null;
        }

        public void WriteToJson()
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(filePath, jsonContent);
                Console.WriteLine($"Data succesfully written to: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurd: {ex.Message}");
            }
        }

        public void ReadFromJson()
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);

                this.users = JsonConvert.DeserializeObject<List<User>>(jsonContent);
                Console.WriteLine($"Succesfully read from: {filePath}");
            } 
            catch (Exception ex) 
            {
                Console.WriteLine($"An error has occurd: {ex.Message}");
            }
        }
    }
}

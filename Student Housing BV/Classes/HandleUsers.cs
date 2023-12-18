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
        public List<User> Users { get; private set; }

        public string FilePath { get; private set; }

        public HandleUsers()
        {
            Users = new List<User>();

            string relativeFilepath = "\\Data\\Json\\Users.json";
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            while (!currentDirectory.EndsWith("\\Student Housing BV"))
            {
                currentDirectory = Directory.GetParent(currentDirectory).FullName;
            }

            this.FilePath = $"{currentDirectory}{relativeFilepath}";
            ReadFromJson();
        }

        public void AddUser(string userName, string password, bool isAdmin)
        {
            int userID = Users.Last().UserID + 1;
            User newUser = new(userName, userID, password, isAdmin);
            Users.Add(newUser);
            WriteToJson();
        }

        public void RemoveUser(User toBeRemvedUser)
        {
            if (toBeRemvedUser.UserID == 0)
            {
                MessageBox.Show("Cannot remove ADMIN");
            }
            else
            {
                if (Users.Contains(toBeRemvedUser))
                {
                    Users.Remove(toBeRemvedUser);
                }
                int queueUserID = 0;
                foreach (User user in Users)
                {
                    user.UserID = queueUserID;
                    queueUserID++;
                }
            }
            WriteToJson();
        }

        public void EditUser(User editedUser)
        {
            if (editedUser.UserID == 0)
            {
                MessageBox.Show("This user cannot be edited");
            }
            else
            {
                foreach (User user in Users)
                {
                    if (user.UserID == editedUser.UserID)
                    {
                        user.UserName = editedUser.UserName;
                        user.Password = editedUser.Password;
                        user.IsAdmin = editedUser.IsAdmin;
                    }
                }
            }
            WriteToJson();
        }

        public User? ValidateUser(User toBeValidatedUser)
        {
            foreach (User user in Users)
            {
                if (toBeValidatedUser.UserName == user.UserName && toBeValidatedUser.Password == user.Password)
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
                string jsonContent = JsonConvert.SerializeObject(Users, Formatting.Indented);
                File.WriteAllText(FilePath, jsonContent);
                Console.WriteLine($"Data succesfully written to: {FilePath}");
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
                string jsonContent = File.ReadAllText(FilePath);

                this.Users = JsonConvert.DeserializeObject<List<User>>(jsonContent);
                Console.WriteLine($"Succesfully read from: {FilePath}");
            } 
            catch (Exception ex) 
            {
                Console.WriteLine($"An error has occurd: {ex.Message}");
            }
        }
    }
}

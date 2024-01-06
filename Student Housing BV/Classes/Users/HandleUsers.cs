using Newtonsoft.Json;


namespace Student_Housing_BV.Classes.Users
{
    public class HandleUsers
    {
        public List<User> Users { get; private set; }

        public string FilePath { get; private set; }



        // Expose Users as IEnumerable<User> for binding
        public IEnumerable<User> UsersEnumerable => Users;

        // Add a property for display in ComboBox
        public string UserDisplayName => "UserName";



        public HandleUsers()
        {
            Users = new List<User>();

            string relativeFilepath = "\\Data\\Json\\Users.json";
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            while (!currentDirectory.EndsWith("\\Student Housing BV"))
            {
                currentDirectory = Directory.GetParent(currentDirectory).FullName;
            }

            FilePath = $"{currentDirectory}{relativeFilepath}";
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

                Users = JsonConvert.DeserializeObject<List<User>>(jsonContent);
                Console.WriteLine($"Succesfully read from: {FilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurd: {ex.Message}");
            }
        }
    }
}

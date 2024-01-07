using Newtonsoft.Json;


namespace Student_Housing_BV.Classes.Users
{
    public class HandleUsers
    {
        public List<User> Users { get; private set; }

        public string FilePath { get; private set; }

        public HandleUsers()
        {
            Users = new List<User>();

            /*This piece of code grabs the source of the file, goes back untill it reaches where all the folders 
             are saved i.e Student Housing BV.

             Once it finds the right file it routes to the Users.json file.*/
            string relativeFilepath = "\\Data\\Json\\Users.json";
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            while (!currentDirectory.EndsWith("\\Student Housing BV"))
            {
                currentDirectory = Directory.GetParent(currentDirectory).FullName;
            }

            FilePath = $"{currentDirectory}{relativeFilepath}";
            ReadFromJson();
        }

        //Method to add a user to the Users list. This method also generates a new UserID for each new user.
        public void AddUser(string userName, string password, bool isAdmin)
        {
            int userID = Users.Last().UserID + 1;
            User newUser = new(userName, userID, password, isAdmin);
            Users.Add(newUser);
            WriteToJson();
        }

        //Method to remove a user from the list
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

        //method to edit an existing user in the list
        public void EditUser(User newUser, User oldUser)
        {
            //this checks if the user has an UserId of 0 (The admin) and if true that that user cannot be edited or deleted
            if (newUser.UserID == 0)
            {
                MessageBox.Show("This user cannot be edited");
            }
            else
            {
                Users[Users.IndexOf(oldUser)] = newUser;
                WriteToJson();
            }
        }

        //Method to validate users for the login process. if the user was found it returns the user else returns null
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

        //Writes all the users in the list to a json file
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

        //reads all the users in the json file and saved it to the list
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


namespace Student_Housing_BV.Classes.Users
{
    public class User
    {
        public string UserName { get; set; }
        public int UserID { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public string DisplayText => $"{UserName} | {UserID}";

        public User(string userName, int userID, string password, bool isAdmin)
        {
            UserName = userName;
            UserID = userID;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}

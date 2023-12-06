namespace Student_Housing_BV
{
    public partial class Login : Form
    {
        List<User> users = new List<User>();
        AdminView adminView = new AdminView();
        User userOne = new User("Aaron", 123, "one", true);
        User userTwo = new User("Friso", 456, "two", false);
        User userThree = new User("Destina", 789, "three", false);
        User userFour = new User("Ernie", 135, "four", true);

        public Login()
        {
            InitializeComponent();
            users.Add(userOne);
            users.Add(userTwo);
            users.Add(userThree);
            users.Add(userFour);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            string stringUserID = tbLoginUserID.Text;
            string password = tbLoginUserPassword.Text;

            if (CanConvertToInt(stringUserID))
            {
                int userID = Convert.ToInt16(stringUserID);
                User toBeValidatedUser = new User(null, userID, password, false);
                User validatedUser = ValidateUser(toBeValidatedUser);

                if (validatedUser != null)
                {
                    MessageBox.Show($"Welcome {validatedUser.userName}, Admin access: {validatedUser.isAdmin}");
                    if(validatedUser.isAdmin)
                    {
                        
                        adminView.Show();
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Try again");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid User ID.");
            }
        }

        public User ValidateUser(User toBeValidateduser)
        {
            foreach (User user in users)
            {
                if (toBeValidateduser.userID == user.userID && toBeValidateduser.password == user.password)
                {
                    return user;
                }
            }
            return null;
        }

        public bool CanConvertToInt(string stringInteger)
        {
            if (int.TryParse(tbLoginUserID.Text, out int userID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
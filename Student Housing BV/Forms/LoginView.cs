using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV
{
    public partial class LoginView : Form
    {
        public HandleUsers HandleUsers { get; set; }

        public LoginView()
        {
            InitializeComponent();
            HandleUsers = new();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbLoginUserID.Text;
            string password = tbLoginUserPassword.Text;

            //Makes a "throwaway" user to be validated
            //Its puirpose is only to check if the username AND paswoord matches any user we may have in the DB
            User toBeValidatedUser = new(userName, -1, password, false);

            //Calls uppon HandleUsers where the validation takes place i.e checks username and password of each user and tries to match them.
            User validatedUser = HandleUsers.ValidateUser(toBeValidatedUser);


            /*If the validation was successfull i.e the user was found the program routes the user to their respectfull form,
            Admins go to adminView and students go to Studentview*/

            /*If the HandleUsers returns null i.e the username and/or password was incorrect it will display a messageBox
             prompting the user to try again*/
            if (validatedUser != null)
            {
                if (validatedUser.IsAdmin)
                {
                    //This is to open the next FormPage, AdminView uses HandleUsers and ValidatedUSer (LoggedInUser) to function properly.
                    //These variables were passed in in similar ways than variables are passed in a constructor
                    AdminViewMainPage adminView = new(HandleUsers, validatedUser);
                    adminView.Show();
                    this.Hide();
                }
                else
                {
                    //This is to open the next FormPage, StudentView uses ValidatedUSer (LoggedInUser) to function properly.
                    //These variables were passed in in similar ways than variables are passed in a constructor
                    StudentViewMainPage studentView = new(validatedUser);
                    studentView.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please make sure your login information is correct");
            }
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
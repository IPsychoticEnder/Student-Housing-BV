using Student_Housing_BV.Classes.Users;


namespace Student_Housing_BV.Forms
{
    public partial class AddUserView : Form
    {
        HandleUsers HandleUsers;
        User LoggedInUser;

        public AddUserView(HandleUsers handleUsers, User loggedInUser)
        {
            InitializeComponent();
            HandleUsers = handleUsers;
            LoggedInUser = loggedInUser;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //Double checks if both baswoords are the same.
            if (tbAddUserUserPassword.Text == tbAddUserCheckUserPassword.Text)
            {
                /*This takes the user input from the form and sends it to the HandleUsers class in which a new
                 user will be created.
                
                 the userID will be generated in the HandleUser class instead of here.*/
                string userName = tbAddUserUserName.Text;
                string password = tbAddUserUserPassword.Text;
                bool isAdmin = cbAddUserUserAdminAccess.Checked;

                HandleUsers.AddUser(userName, password, isAdmin);

                UsersListView usersListView = new UsersListView(HandleUsers, LoggedInUser);
                usersListView.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a correct password");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Returns back to the previous form without adding a user
            UsersListView usersListView = new UsersListView(HandleUsers, LoggedInUser);
            usersListView.Show();
            this.Close();
        }
    }
}

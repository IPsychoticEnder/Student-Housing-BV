using Student_Housing_BV.Classes;


namespace Student_Housing_BV.Forms
{
    public partial class AddUserView : Form
    {
        UsersListView usersListView;

        HandleUsers handleUsers;
        User loggedInUser;

        public AddUserView(HandleUsers handleUsers, User loggedInUser)
        {
            InitializeComponent();
            this.handleUsers = handleUsers;
            this.loggedInUser = loggedInUser;

            usersListView = new(handleUsers, loggedInUser);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (tbAddUserUserPassword.Text == tbAddUserCheckUserPassword.Text)
            {
                string userName = tbAddUserUserName.Text;
                string password = tbAddUserUserPassword.Text;
                bool isAdmin = cbAddUserUserAdminAccess.Checked;

                handleUsers.AddUser(userName, password, isAdmin);

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
            usersListView.Show();
            this.Close();
        }
    }
}

using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV.Forms.UsersView
{
    public partial class EditUserView : Form
    {
        HandleUsers HandleUsers;
        User LoggedInUsers;
        User SelectedUser;

        public EditUserView(HandleUsers handleUsers, User loggedInUser, User selectedUser)
        {
            InitializeComponent();
            HandleUsers = handleUsers;
            LoggedInUsers = loggedInUser;
            SelectedUser = selectedUser;

            //Populates the form with the existing content of the user which is being edited.
            tbEditUserUserName.Text = selectedUser.UserName;
            tbEditUserUserID.Text = Convert.ToString(selectedUser.UserID);
            tbEditUserUserPassword.Text = selectedUser.Password;
            cbEditUserUserAdminAccess.Checked = selectedUser.IsAdmin;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            //Creates a newUser with the new information entered by the admin, then calls uppon HandleUsers to Edit the User.
            string newUserName = tbEditUserUserName.Text;
            int newUserID = Convert.ToInt16(tbEditUserUserID.Text);
            string newUserPassword = tbEditUserUserPassword.Text;
            bool newIsAdmin = cbEditUserUserAdminAccess.Checked;

            User newUser = new User(newUserName, newUserID, newUserPassword, newIsAdmin);
            HandleUsers.EditUser(SelectedUser, newUser);

            UsersListView usersListView = new UsersListView(HandleUsers, LoggedInUsers);
            usersListView.Show();
            this.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //Calls uppon HandleUsers to delete the user which is being edited.
            //Maybe add some extra validation i.e "Are you sure you want to delete this user?"
            HandleUsers.RemoveUser(SelectedUser);
            UsersListView usersListView = new UsersListView(HandleUsers, LoggedInUsers);
            usersListView.Show();
            this.Close();
        }
    }
}

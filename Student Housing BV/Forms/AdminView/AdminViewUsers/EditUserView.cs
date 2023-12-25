

using Student_Housing_BV.Classes;

namespace Student_Housing_BV.Forms.UsersView
{
    public partial class EditUserView : Form
    {
        HandleUsers handleUsers;
        User loggedInUser;
        List<User> users;
        User selectedUser;

        public EditUserView(HandleUsers handleUsers, User loggedInUser, User selectedUser)
        {
            InitializeComponent();
            this.handleUsers = handleUsers;
            this.loggedInUser = loggedInUser;
            this.users = handleUsers.Users;
            this.selectedUser = selectedUser;

            tbEditUserUserName.Text = selectedUser.UserName;
            tbEditUserUserID.Text = Convert.ToString(selectedUser.UserID);
            tbEditUserUserPassword.Text = selectedUser.Password;
            cbEditUserUserAdminAccess.Checked = selectedUser.IsAdmin;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string newUserName = tbEditUserUserName.Text;
            int newUserID = Convert.ToInt16(tbEditUserUserID.Text);
            string newUserPassword = tbEditUserUserPassword.Text;
            bool newIsAdmin = cbEditUserUserAdminAccess.Checked;

            User newEditedUser = new User(newUserName, newUserID, newUserPassword, newIsAdmin);
            handleUsers.EditUser(newEditedUser);

            UsersListView usersListView = new UsersListView(handleUsers, loggedInUser);
            usersListView.Show();
            this.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            handleUsers.RemoveUser(selectedUser);
            UsersListView usersListView = new UsersListView(handleUsers, loggedInUser);
            usersListView.Show();
            this.Close();
        }
    }
}

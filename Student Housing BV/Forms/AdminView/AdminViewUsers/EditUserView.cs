

using Student_Housing_BV.Classes;

namespace Student_Housing_BV.Forms.UsersView
{
    public partial class EditUserView : Form
    {
        HandleUsers handleUsers;
        User loggedInUser;
        User selectedUser;

        UsersListView usersListView;

        public EditUserView(HandleUsers handleUsers, User loggedInUser, User selectedUser)
        {
            InitializeComponent();

            this.handleUsers = handleUsers;
            this.loggedInUser = loggedInUser;
            this.selectedUser = selectedUser;

            usersListView = new(handleUsers, loggedInUser);

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

            usersListView.Show();
            this.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            handleUsers.RemoveUser(selectedUser);
            usersListView.Show();
            this.Close();
        }
    }
}

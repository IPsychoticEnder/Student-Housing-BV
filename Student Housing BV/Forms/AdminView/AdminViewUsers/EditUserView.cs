﻿

using Student_Housing_BV.Classes;

namespace Student_Housing_BV.Forms.UsersView
{
    public partial class EditUserView : Form
    {
        HandleUsers handleUsers;
        User loggedInUser;
        List<User> users;
        User userBeingEdited;

        public EditUserView(HandleUsers handleUsers, User loggedInUser, int rowIndex)
        {
            InitializeComponent();
            this.handleUsers = handleUsers;
            this.loggedInUser = loggedInUser;
            this.users = handleUsers.Users;

            foreach (User user in users)
            {
                if (user.UserID == rowIndex)
                {
                    this.userBeingEdited = user;
                }
            }

            tbEditUserUserName.Text = userBeingEdited.UserName;
            tbEditUserUserID.Text = Convert.ToString(userBeingEdited.UserID);
            tbEditUserUserPassword.Text = userBeingEdited.Password;
            cbEditUserUserAdminAccess.Checked = userBeingEdited.IsAdmin;
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
            handleUsers.RemoveUser(userBeingEdited);
            UsersListView usersListView = new UsersListView(handleUsers, loggedInUser);
            usersListView.Show();
            this.Close();
        }
    }
}

using Student_Housing_BV.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Housing_BV.Forms
{
    public partial class AddUserView : Form
    {
        HandleUsers handleUsers;
        User loggedInUser;

        public AddUserView(HandleUsers handleUsers, User loggedInUser)
        {
            InitializeComponent();
            this.handleUsers = handleUsers;
            this.loggedInUser = loggedInUser;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (tbAddUserUserPassword.Text == tbAddUserCheckUserPassword.Text)
            {
                string userName = tbAddUserUserName.Text;
                string password = tbAddUserUserPassword.Text;
                bool isAdmin = cbAddUserUserAdminAccess.Checked;

                handleUsers.AddUser(userName, password, isAdmin);

                UsersListView usersListView = new UsersListView(handleUsers, loggedInUser);
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
            UsersListView usersListView = new UsersListView(handleUsers, loggedInUser);
            usersListView.Show();
            this.Close();
        }
    }
}

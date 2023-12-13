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

        public AddUserView(HandleUsers handleUsers)
        {
            InitializeComponent();
            this.handleUsers = handleUsers;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (tbAddUserUserPassword.Text == tbAddUserCheckUserPassword.Text)
            {
                string userName = tbAddUserUserName.Text;
                string password = tbAddUserUserPassword.Text;
                bool isAdmin = cbAddUserUserAdminAccess.Checked;

                handleUsers.AddUser(userName, password, isAdmin);

                UsersListView usersListView = new UsersListView(handleUsers);
                usersListView.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a correct password");
            }
        }
    }
}

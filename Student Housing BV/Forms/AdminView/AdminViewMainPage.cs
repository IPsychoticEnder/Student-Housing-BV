using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Housing_BV.Classes;
using Student_Housing_BV.Forms;

namespace Student_Housing_BV
{
    public partial class AdminViewMainPage : Form
    {
        HandleUsers handleUsers;
        User loggedInUser;


        public AdminViewMainPage(HandleUsers users, User loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.handleUsers = users;
            lbWelcomeUser.Text = $"Welcome {this.loggedInUser.UserName}";
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            UsersListView usersListView = new UsersListView(handleUsers, loggedInUser);
            usersListView.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Close();
        }
    }
}

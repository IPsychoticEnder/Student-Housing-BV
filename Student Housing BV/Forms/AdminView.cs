﻿using System;
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
    public partial class AdminView : Form
    {
        HandleUsers handleUsers;
        User loggedInUser;


        public AdminView(HandleUsers handleUsers, User loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.handleUsers = handleUsers;
            lbWelcomeUser.Text = $"Welcome {this.loggedInUser.userName}";
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            UsersListView usersListView = new UsersListView(handleUsers, loggedInUser);
            usersListView.Show();
            this.Close();
        }

    }
}

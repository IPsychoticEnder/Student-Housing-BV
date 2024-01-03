using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV
{
    public partial class StudentView : Form
    {
        public User LoggedInUser;

        public StudentView(User loggedInUser)
        {
            InitializeComponent();
            this.LoggedInUser = loggedInUser;
            label1.Text = $"Welcome {loggedInUser.UserName}";
            label2.Text = $"Admin access: {loggedInUser.IsAdmin}";
        }
    }
}

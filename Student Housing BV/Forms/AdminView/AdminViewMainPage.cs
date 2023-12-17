using Student_Housing_BV.Classes;
using Student_Housing_BV.Forms;
using Student_Housing_BV.Forms.AdminView.AdminViewAgreements;
using Student_Housing_BV.Forms.AdminView.AdminViewTasks;

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
            UsersListView usersListView = new(handleUsers, loggedInUser);
            usersListView.Show();
            this.Hide();
        }

        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            TasksListView tasksListView = new();
            tasksListView.Show();
            this.Close();
        }

        private void btnViewAgreements_Click(object sender, EventArgs e)
        {
            AgreementsListView agreementsListView = new(handleUsers, loggedInUser);
            agreementsListView.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginView loginView = new();
            loginView.Show();
            this.Close();
        }
    }
}

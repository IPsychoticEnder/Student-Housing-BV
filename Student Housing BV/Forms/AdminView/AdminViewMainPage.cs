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

        UsersListView usersListView;
        TasksListView tasksListView;
        AgreementsListView agreementsListView;


        public AdminViewMainPage(HandleUsers handleUsers, User loggedInUser)
        {
            InitializeComponent();
            this.handleUsers = handleUsers;
            this.loggedInUser = loggedInUser;
            lbWelcomeUser.Text = $"Welcome {this.loggedInUser.UserName}";

            usersListView = new(handleUsers, loggedInUser);
            tasksListView = new();
            agreementsListView = new(handleUsers, loggedInUser);
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            usersListView.Show();
            this.Hide();
        }

        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            tasksListView.Show();
            this.Close();
        }

        private void btnViewAgreements_Click(object sender, EventArgs e)
        {
            agreementsListView.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Close();
        }
    }
}

using Student_Housing_BV.Classes.StudentAgreements;
using Student_Housing_BV.Classes.Users;
using Student_Housing_BV.Forms;
using Student_Housing_BV.Forms.AdminView.AdminViewAgreements;
using Student_Housing_BV.Forms.AdminView.AdminViewStudentAgreements;
using Student_Housing_BV.Forms.AdminView.AdminViewTasks;

namespace Student_Housing_BV
{
    public partial class AdminViewMainPage : Form
    {
        public HandleUsers HandleUsers { get; private set; }
        public User LoggedInUser { get; private set; }


        public AdminViewMainPage(HandleUsers users, User loggedInUser)
        {
            InitializeComponent();
            LoggedInUser = loggedInUser;
            HandleUsers = users;
            lbWelcomeUser.Text = $"Welcome {this.LoggedInUser.UserName}";
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            /*Routes the user to the UserListView passing through HandleUsers and LoggedInUser similar to a varable
             being passed through a constructor in a class*/
            UsersListView UserListView = new(HandleUsers, LoggedInUser);
            UserListView.Show();
            this.Close();
        }

        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            /*Routes the user to the TaskListView passing through HandleUsers and LoggedInUser similar to a varable
             being passed through a constructor in a class*/
            TaskListView TaskListView = new(HandleUsers, LoggedInUser);
            TaskListView.Show();
            this.Close();
        }

        private void btnViewAgreements_Click(object sender, EventArgs e)
        {
            /*Routes the user to the AgreementListView passing through HandleUsers and LoggedInUser similar to a varable
             being passed through a constructor in a class*/
            AgreementsListView AgreementsListView = new(HandleUsers, LoggedInUser);
            AgreementsListView.Show();
            this.Close();
        }

        private void btnViewStudentAgreements_Click(object sender, EventArgs e)
        {
            StudentAgreementListView form = new(this);
            form.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            /*Routes the user back to the LoginView signing them out.
             LoginView does not require any variables to work, therefor nothing is passed through.*/
            LoginView loginView = new();
            loginView.Show();
            this.Close();
        }
    }
}

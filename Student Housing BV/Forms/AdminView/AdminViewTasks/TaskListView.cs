using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV.Forms.AdminView.AdminViewTasks
{
    public partial class TaskListView : Form
    {
        HandleUsers handleUsers;
        User loggedInUser;

        public TaskListView(HandleUsers handleUsers, User loggedInUser)
        {
            this.handleUsers = handleUsers;
            this.loggedInUser = loggedInUser;

            InitializeComponent();
        }

        private void btnBackToAdminView_Click(object sender, EventArgs e)
        {
            AdminViewMainPage adminViewMainPage = new(handleUsers, loggedInUser);
            adminViewMainPage.Show();
            this.Close();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {

        }
    }
}

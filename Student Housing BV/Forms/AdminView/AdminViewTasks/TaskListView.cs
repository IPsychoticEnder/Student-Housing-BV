using Student_Housing_BV.Classes.Tasks;
using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV.Forms.AdminView.AdminViewTasks
{
    public partial class TaskListView : Form
    {
        private HandleUsers HandleUsers;
        private HandleTasks HandleTasks;
        private User LoggedInUser;

        private List<Classes.Tasks.Task> Tasks { get; set; }

        public TaskListView(HandleUsers handleUsers, User loggedInUser)
        {
            InitializeComponent();
            HandleUsers = handleUsers;
            LoggedInUser = loggedInUser;
            HandleTasks = new HandleTasks();

            Tasks = HandleTasks.Tasks;
            dataGridDisplayAllTasks.DataSource = Tasks;

        }

        private void btnBackToAdminView_Click(object sender, EventArgs e)
        {
            AdminViewMainPage adminViewMainPage = new(HandleUsers, LoggedInUser);
            adminViewMainPage.Show();
            this.Close();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {

            Dictionary<string, bool> DueDate = new Dictionary<string, bool>
            {
                { "Monday", false },
                { "Wednesday", false}
            };

            Classes.Tasks.Task newtask = new("testing", "testing the description", DueDate);
            HandleTasks.AddTask(newtask);
        }
    }
}

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

            //gets the list of Tasks from the HandleTasks that was passed throught AdminViewHomePage
            //Sets the data inside the dataGrid to that of the list.
            Tasks = HandleTasks.Tasks;
            dataGridDisplayAllTasks.DataSource = Tasks;

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            /*This button redirects you to the AddTaskView Form. to work properly it requires HandleUsers and LoggedInUser
            which was passed through just like a variable in a class through a consturctor*/
            AddTaskView Addtaskview = new(HandleUsers, LoggedInUser);
            Addtaskview.Show();
            this.Hide();
        }

        private void btnBackToAdminView_Click(object sender, EventArgs e)
        {
            /*This button redirects you back to the AdminView Form. to work properly it requires HandleUsers and LoggedInUser
            which was passed through just like a variable in a class through a consturctor*/
            AdminViewMainPage adminViewMainPage = new(HandleUsers, LoggedInUser);
            adminViewMainPage.Show();
            this.Close();
        }

        private void dataGridDisplayAllTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*This returns item of the row you clicked in the DataGrid.
            Once you double click on a Tasks in the DataGrid it Creates the selectedTask variable and sets it to the content of the Task you clicked
            
            After that it opens the EditTaskView form in which in passes through the corresponding variables similar to
            a constructor in a class*/
            Classes.Tasks.Task SelectedTask = (Classes.Tasks.Task)dataGridDisplayAllTasks.SelectedRows[0].DataBoundItem;
            EditTaskView EditTaskView = new(SelectedTask, HandleUsers, HandleTasks, LoggedInUser);
            EditTaskView.Show();
            this.Hide();
        }
    }
}

using Student_Housing_BV.Classes.Tasks;
using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV.Forms.AdminView.AdminViewTasks
{
    public partial class AddTaskView : Form
    {
        HandleUsers HandleUsers { get; set; }
        User LoggedInUser { get; set; }

        HandleTasks HandleTasks = new();

        public AddTaskView(HandleUsers handleUsers, User loggedInUser)
        {
            InitializeComponent();

            HandleUsers = handleUsers;
            LoggedInUser = loggedInUser;
            

            List<User> nonAdminUsers = handleUsers.Users.Where(user => !user.IsAdmin).ToList();
            cmboxSelectUser.DataSource = nonAdminUsers;
            cmboxSelectUser.DisplayMember = "UserName";
            cmboxSelectUser.SelectedItem = null;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string TaskName = tbNewTaskTitle.Text;
            string TaskDescription = tbNewTaskDescription.Text;

            Dictionary<string, bool> Duedates = new Dictionary<string, bool>();

            if (cbMondayInput.Checked)
            {
                Duedates.Add("Monday", false);
            }
            if (cbTuesdayInput.Checked)
            {
                Duedates.Add("Tuesday", false);
            }
            if (cbWednesdayInput.Checked)
            {
                Duedates.Add("Wednesday", false);
            }
            if (cbThursdayInput.Checked)
            {
                Duedates.Add("Thursday", false);
            }
            if (cbFridayInput.Checked)
            {
                Duedates.Add("Friday", false);
            }
            if (cbSaturdayInput.Checked)
            {
                Duedates.Add("Saturday", false);
            }

            User selectedUser = (User)cmboxSelectUser.SelectedValue;

            Classes.Tasks.Task newTask = new(TaskName, TaskDescription, Duedates, selectedUser);
            HandleTasks.AddTask(newTask);

            TaskListView TaskListView = new(HandleUsers, LoggedInUser);
            TaskListView.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TaskListView TaskListView = new(HandleUsers, LoggedInUser);
            TaskListView.Show();
            this.Close();
        }
    }
}

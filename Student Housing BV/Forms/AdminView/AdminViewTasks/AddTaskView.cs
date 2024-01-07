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
            
            //Makes a new list of all users that are not admin to display in the combobox (Dropdown menu)
            List<User> nonAdminUsers = handleUsers.Users.Where(user => !user.IsAdmin).ToList();
            cmboxSelectUser.DataSource = nonAdminUsers;
            cmboxSelectUser.DisplayMember = "UserName";
            cmboxSelectUser.SelectedItem = null;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            //Adds a new Task to the list of tasks (stored in HandleTasks)
            string TaskName = tbNewTaskTitle.Text;
            string TaskDescription = tbNewTaskDescription.Text;


            /*Checks each checkbox wether or not its checked then adds the corresponding day to the dictionary
             
            This dictionary contains of a key: the day, and a value: true/false.
            Using the correlation between the key and value we are able to set the "isDone" for that day to true if the task was completed.*/
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
            //returns back to the TaskListView form without making any changes
            TaskListView TaskListView = new(HandleUsers, LoggedInUser);
            TaskListView.Show();
            this.Close();
        }
    }
}

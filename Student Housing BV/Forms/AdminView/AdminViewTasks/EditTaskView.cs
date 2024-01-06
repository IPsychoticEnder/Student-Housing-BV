using Student_Housing_BV.Classes.Users;
using Student_Housing_BV.Classes.Tasks;

namespace Student_Housing_BV.Forms.AdminView.AdminViewTasks
{
    public partial class EditTaskView : Form
    {
        public HandleUsers HandleUsers { get; set; }
        public HandleTasks HandleTasks { get; set; }
        public User LoggedInUser { get; set; }
        public Classes.Tasks.Task SelectedTask { get; set; }

        public EditTaskView(Classes.Tasks.Task selectedTask, HandleUsers handleUsers, HandleTasks handleTasks, User loggedInUser)
        {
            InitializeComponent();
            HandleUsers = handleUsers;
            HandleTasks = handleTasks;
            LoggedInUser = loggedInUser;
            SelectedTask = selectedTask;

            tbTaskTitle.Text = selectedTask.Name;
            tbTaskDescription.Text = selectedTask.Description;

            Dictionary<string, bool> DueDates = SelectedTask.DueDates;

            foreach (var dueDate in DueDates)
            {
                if(dueDate.Key == "Monday")
                {
                    cbMondayInput.Checked = true;
                }
                if (dueDate.Key == "Tuesday")
                {
                    cbTuesdayInput.Checked = true;
                }
                if (dueDate.Key == "Wednesday")
                {
                    cbWednesdayInput.Checked = true;
                }
                if (dueDate.Key == "Thursday")
                {
                    cbThursdayInput.Checked = true;
                }
                if (dueDate.Key == "Friday")
                {
                    cbFridayInput.Checked = true;
                }
                if (dueDate.Key == "Saturday")
                {
                    cbSaturdayInput.Checked = true;
                }
            }

            List<User> nonAdminUsers = HandleUsers.Users.Where(user => !user.IsAdmin).ToList();
            cmboxSelectUser.DataSource = nonAdminUsers;
            cmboxSelectUser.DisplayMember = "DisplayText";

            User userToSelect = nonAdminUsers.FirstOrDefault(user => user.UserID == selectedTask.UserInCharge.UserID);

            if (userToSelect != null)
            {
                cmboxSelectUser.SelectedItem = userToSelect;
            }
            else
            {
                cmboxSelectUser.SelectedItem = null;
            }
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            string NewTitle = tbTaskTitle.Text;
            string NewDescription = tbTaskDescription.Text;

            Dictionary<string, bool> NewDuedates = new Dictionary<string, bool>();
            if (cbMondayInput.Checked)
            {
                NewDuedates.Add("Monday", false);
            }
            if (cbTuesdayInput.Checked)
            {
                NewDuedates.Add("Tuesday", false);
            }
            if (cbWednesdayInput.Checked)
            {
                NewDuedates.Add("Wednesday", false);
            }
            if (cbThursdayInput.Checked)
            {
                NewDuedates.Add("Thursday", false);
            }
            if (cbFridayInput.Checked)
            {
                NewDuedates.Add("Friday", false);
            }
            if (cbSaturdayInput.Checked)
            {
                NewDuedates.Add("Saturday", false);
            }

            User selectedUser = (User)cmboxSelectUser.SelectedValue;

            Classes.Tasks.Task newTask = new(NewTitle, NewDescription, NewDuedates, selectedUser);
            HandleTasks.EditTask(SelectedTask, newTask);

            TaskListView TaskListView = new(HandleUsers, LoggedInUser);
            TaskListView.Show();
            this.Close();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            HandleTasks.RemoveTask(SelectedTask);

            TaskListView TaskListView = new(HandleUsers, LoggedInUser);
            TaskListView.Show();
            this.Close();
        }
    }
}

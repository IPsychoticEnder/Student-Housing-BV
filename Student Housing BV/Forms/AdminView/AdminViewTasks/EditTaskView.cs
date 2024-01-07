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

            //Populates the form with the existing content of the Task which is being edited.
            tbTaskTitle.Text = selectedTask.Name;
            tbTaskDescription.Text = selectedTask.Description;

            //Creates an empty dictionary that will hold the days the task has to be done
            Dictionary<string, bool> DueDates = SelectedTask.DueDates;

            /*Checks each checkbox wether or not its checked then adds the corresponding day to the dictionary
             
            This dictionary contains of a key: the day, and a value: true/false.
            Using the correlation between the key and value we are able to set the "isDone" for that day to true if the task was completed.*/
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

            /*Makes a list of users that do not have admin access (in theory the owner wouldnt be washing dishes there)

            Data binds the new list of users to the combobox.
            Sets the DisplayMember of the combobox (What is shown on the dropdown) to "DisplayText" which can be changed to display
            something different in the User class 
            (public string DisplayText => $"{UserName} | {UserID}";) This can be changed to display something else i.e Username and paswoord*/
            List<User> nonAdminUsers = HandleUsers.Users.Where(user => !user.IsAdmin).ToList();
            cmboxSelectUser.DataSource = nonAdminUsers;
            cmboxSelectUser.DisplayMember = "DisplayText";

            /*This goes through the nonAdminUsers list and crosschecks it with the selectedTask.UserInCharge.UserID to find the user of the
             task which is selected.
            
             Each user has a unique UserID so it cross reffrences that.*/
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
            //Saves the Edited data to a newTask then send it through the HandleTasks class to make the edit.
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
            //Deletes the Task completely
            //Maybe add some extra validation i.e "Are you sure you want to delete this Task?"
            HandleTasks.RemoveTask(SelectedTask);

            TaskListView TaskListView = new(HandleUsers, LoggedInUser);
            TaskListView.Show();
            this.Close();
        }
    }
}

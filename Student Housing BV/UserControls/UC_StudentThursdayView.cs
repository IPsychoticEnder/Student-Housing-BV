using Student_Housing_BV.Classes.Tasks;
using Student_Housing_BV.Classes.Users;
using Student_Housing_BV.UserControls.Components;

namespace Student_Housing_BV.UserControls
{
    public partial class UC_StudentThursdayView : UserControl
    {
        HandleTasks HandleTasks { get; set; }
        User LoggedInUser { get; set; }

        List<Classes.Tasks.Task> Tasks = new List<Classes.Tasks.Task>();

        public UC_StudentThursdayView(User loggedInUser)
        {
            InitializeComponent();
            HandleTasks = new();
            LoggedInUser = loggedInUser;

            Tasks = HandleTasks.Tasks;

            DisplayUserSpecificTasks();
        }

        private void DisplayUserSpecificTasks()
        {
            foreach (Classes.Tasks.Task task in Tasks)
            {
                if (task.UserInCharge.UserID == LoggedInUser.UserID)
                {
                    foreach (var day in task.DueDates)
                    {
                        if (day.Key == "Thursday")
                        {
                            DisplayTaskComponent uc = new(task);
                            AddTaskComponent(uc);
                        }
                    }
                }
            }
        }

        private void AddTaskComponent(UserControl userControl)
        {
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}

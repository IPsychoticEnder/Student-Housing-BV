using Student_Housing_BV.Classes.Users;
using Student_Housing_BV.Classes.Tasks;
using Student_Housing_BV.UserControls.Components;

namespace Student_Housing_BV.UserControls
{
    public partial class UC_DailyTaskView : UserControl
    {
        HandleTasks HandleTasks { get; set; }
        User LoggedInUser { get; set; }
        List<Classes.Tasks.Task> Tasks { get; set; }

        string Day { get; set; }

        public UC_DailyTaskView(User loggedInUser, string day)
        {
            InitializeComponent();
            HandleTasks = new();
            Tasks = HandleTasks.Tasks;
            LoggedInUser = loggedInUser;
            Day = day;

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
                        if (day.Key == Day)
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

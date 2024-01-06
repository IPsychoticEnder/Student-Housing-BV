using Student_Housing_BV.Classes.Tasks;
using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV.UserControls
{
    public partial class UC_StudentMondayView : UserControl
    {

        HandleTasks HandleTasks { get; set; }
        User LoggedInUser { get; set; }

        List<Classes.Tasks.Task> Tasks = new List<Classes.Tasks.Task>();

        public UC_StudentMondayView(User loggedInUser)
        {
            InitializeComponent();
            HandleTasks = new();
            LoggedInUser = loggedInUser;

            Tasks = HandleTasks.Tasks;
        }
    }
}

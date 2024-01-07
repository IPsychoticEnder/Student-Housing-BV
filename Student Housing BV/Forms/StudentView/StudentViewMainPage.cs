using Student_Housing_BV.Classes.Users;
using Student_Housing_BV.UserControls;

namespace Student_Housing_BV
{
    public partial class StudentViewMainPage : Form
    {
        public User LoggedInUser;

        public StudentViewMainPage(User loggedInUser)
        {
            InitializeComponent();
            this.LoggedInUser = loggedInUser;
            lblDisplayStudentName.Text = $"{loggedInUser.UserName}";
        }

        private void AdduserControl(UserControl userControl)
        {
            PanelMainContent.Dock = DockStyle.Fill;
            PanelMainContent.Controls.Clear();
            PanelMainContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ChangeButtonsToDefault()
        {
            btnRouteToMonday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToTuesday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToWednesday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToThursday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToFriday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToSaturday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToSunday.BackColor = Color.FromArgb(188, 212, 222);
        }

        private void btnRouteToMonday_Click(object sender, EventArgs e)
        {
            ChangeButtonsToDefault();
            btnRouteToMonday.BackColor = Color.FromArgb(134, 97, 193);

            UC_DailyTaskView uc = new(LoggedInUser, "Monday");
            AdduserControl(uc);
        }

        private void btnRouteToTuesday_Click(object sender, EventArgs e)
        {
            ChangeButtonsToDefault();
            btnRouteToTuesday.BackColor = Color.FromArgb(134, 97, 193);

            UC_DailyTaskView uc = new(LoggedInUser, "Tuesday");
            AdduserControl(uc);
        }

        private void btnRouteToWednesday_Click(object sender, EventArgs e)
        {
            ChangeButtonsToDefault();
            btnRouteToWednesday.BackColor = Color.FromArgb(134, 97, 193);

            UC_DailyTaskView uc = new(LoggedInUser, "Wednesday");
            AdduserControl(uc);
        }

        private void btnRouteToThursday_Click(object sender, EventArgs e)
        {
            ChangeButtonsToDefault();
            btnRouteToThursday.BackColor = Color.FromArgb(134, 97, 193);

            UC_DailyTaskView uc = new(LoggedInUser, "Thursday");
            AdduserControl(uc);
        }

        private void btnRouteToFriday_Click(object sender, EventArgs e)
        {
            ChangeButtonsToDefault();
            btnRouteToFriday.BackColor = Color.FromArgb(134, 97, 193);

            UC_DailyTaskView uc = new(LoggedInUser, "Friday");
            AdduserControl(uc);
        }

        private void btnRouteToSaturday_Click(object sender, EventArgs e)
        {
            ChangeButtonsToDefault();
            btnRouteToSaturday.BackColor = Color.FromArgb(134, 97, 193);

            UC_DailyTaskView uc = new(LoggedInUser, "Saturday");
            AdduserControl(uc);
        }

        private void btnRouteToSunday_Click(object sender, EventArgs e)
        {
            ChangeButtonsToDefault();
            btnRouteToSunday.BackColor = Color.FromArgb(134, 97, 193);

            UC_DailyTaskView uc = new(LoggedInUser, "Sunday");
            AdduserControl(uc);
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginView loginView = new();
            loginView.Show();
            this.Close();
        }
    }
}

﻿using Student_Housing_BV.Classes.Complaints;
using Student_Housing_BV.Classes.Users;
using Student_Housing_BV.UserControls;

namespace Student_Housing_BV
{
    public partial class StudentViewMainPage : Form
    {
        private User LoggedInUser;
        private DateTime Today = DateTime.Now;
        private List<Complaint> MyComplaint;

        public HandleComplaints HandleComplaints { get; private set; }

        public StudentViewMainPage(User loggedInUser)
        {
            InitializeComponent();
            LoggedInUser = loggedInUser;
            HandleComplaints = new();
            lblDisplayStudentName.Text = $"{loggedInUser.UserName}";
            InitTodaysTasks();

            MyComplaint = HandleComplaints.Complaints.Where(complaint => complaint.Accused.UserID == loggedInUser.UserID).ToList();

            if (MyComplaint.Count > 0)
            {
                btnViewMyComplaints.Enabled = true;
                btnViewMyComplaints.BackColor = Color.FromArgb(255, 224, 192);
                btnViewMyComplaints.ForeColor = Color.Black;
            }
        }

        private void AdduserControl(UserControl userControl)
        {
            PanelMainContent.Dock = DockStyle.Fill;
            PanelMainContent.Controls.Clear();
            PanelMainContent.Controls.Add(userControl);
            userControl.BringToFront();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginView loginView = new();
            loginView.Show();
            this.Close();
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

        private void InitTodaysTasks()
        {
            if ($"{Today.DayOfWeek}" == "Monday")
            {
                ChangeButtonsToDefault();
                btnRouteToMonday.BackColor = Color.FromArgb(134, 97, 193);

                UC_DailyTaskView uc = new(LoggedInUser, "Monday");
                AdduserControl(uc);
            }
            else if ($"{Today.DayOfWeek}" == "Tuesday")
            {
                ChangeButtonsToDefault();
                btnRouteToTuesday.BackColor = Color.FromArgb(134, 97, 193);

                UC_DailyTaskView uc = new(LoggedInUser, "Tuesday");
                AdduserControl(uc);
            }
            else if ($"{Today.DayOfWeek}" == "Wednesday")
            {
                ChangeButtonsToDefault();
                btnRouteToWednesday.BackColor = Color.FromArgb(134, 97, 193);

                UC_DailyTaskView uc = new(LoggedInUser, "Wednesday");
                AdduserControl(uc);
            }
            else if ($"{Today.DayOfWeek}" == "Thursday")
            {
                ChangeButtonsToDefault();
                btnRouteToThursday.BackColor = Color.FromArgb(134, 97, 193);

                UC_DailyTaskView uc = new(LoggedInUser, "Thursday");
                AdduserControl(uc);
            }
            else if ($"{Today.DayOfWeek}" == "Friday")
            {
                ChangeButtonsToDefault();
                btnRouteToFriday.BackColor = Color.FromArgb(134, 97, 193);

                UC_DailyTaskView uc = new(LoggedInUser, "Friday");
                AdduserControl(uc);
            }
            else if ($"{Today.DayOfWeek}" == "Saturday")
            {
                ChangeButtonsToDefault();
                btnRouteToSaturday.BackColor = Color.FromArgb(134, 97, 193);

                UC_DailyTaskView uc = new(LoggedInUser, "Saturday");
                AdduserControl(uc);
            }
            else if ($"{Today.DayOfWeek}" == "Sunday")
            {
                ChangeButtonsToDefault();
                btnRouteToSunday.BackColor = Color.FromArgb(134, 97, 193);

                UC_DailyTaskView uc = new(LoggedInUser, "Sunday");
                AdduserControl(uc);
            }
        }

        private void btnViewHouseRules_Click(object sender, EventArgs e)
        {
            ChangeButtonsToDefault();
            UC_ViewHouseRules uc = new();
            AdduserControl(uc);
        }

        private void btnGiveComplaint_Click(object sender, EventArgs e)
        {
            ChangeButtonsToDefault();
            UC_GiveComplaintView uc = new(LoggedInUser);
            AdduserControl(uc);
        }

        private void btnViewMyComplaints_Click(object sender, EventArgs e)
        {
            ChangeButtonsToDefault();
            UC_ViewMyComplaints uc = new(MyComplaint);
            AdduserControl(uc);
        }
    }
}

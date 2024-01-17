using Student_Housing_BV.Classes.Complaints;
using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV.UserControls
{
    public partial class UC_GiveComplaintView : UserControl
    {
        private User LoggedInUser;
        private HandleComplaints HandleComplaints;
        private HandleUsers HandleUsers;
        private Complaint NewComplaint;

        public UC_GiveComplaintView(User loggedInUser)
        {
            InitializeComponent();
            LoggedInUser = loggedInUser;
            HandleComplaints = new();
            HandleUsers = new();
            cbbDisplayAllUsers.DataSource = HandleUsers.Users.Where(user => !user.IsAdmin && user.UserName != loggedInUser.UserName).ToList();
            cbbDisplayAllUsers.DisplayMember = "UserName";

            panelDisplayComplaint.Hide();
            btnConfirmComplaint.Hide();
            lbDisplayAfterButton.Hide();
            lbDisplayComplaintInfo.Hide();
        }

        private void btnPlaceComplaint_Click(object sender, EventArgs e)
        {
            if (tbComplaintDescription.Text == "")
            {
                MessageBox.Show("Please provide a reason for your complaint");
            }
            else
            {
                panelDisplayComplaint.Show();
                btnConfirmComplaint.Show();
                lbDisplayAfterButton.Show();
                lbDisplayComplaintInfo.Show();

                NewComplaint = new(LoggedInUser, (User)cbbDisplayAllUsers.SelectedItem, tbComplaintDescription.Text);
                lbDisplayComplaintInfo.Text = NewComplaint.ToString();
            }
        }

        private void btnConfirmComplaint_Click(object sender, EventArgs e)
        {
            HandleComplaints.AddComplaint(NewComplaint);
            panelDisplayComplaint.Hide();
            btnConfirmComplaint.Hide();
            lbDisplayAfterButton.Hide();
            lbDisplayComplaintInfo.Hide();

            tbComplaintDescription.Text = "";
        }
    }
}

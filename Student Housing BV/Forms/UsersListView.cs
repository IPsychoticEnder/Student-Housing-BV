using Student_Housing_BV.Classes;

namespace Student_Housing_BV.Forms
{
    public partial class UsersListView : Form
    {
        User loggedInUser;
        public UsersListView(User loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToAdminView_Click(object sender, EventArgs e)
        {
            AdminView adminView = new AdminView(loggedInUser);
            adminView.Show();
            this.Hide();
        }
    }
}

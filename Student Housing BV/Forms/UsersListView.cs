using Student_Housing_BV.Classes;

namespace Student_Housing_BV.Forms
{
    public partial class UsersListView : Form
    {
        HandleUsers handleUsers;
        User loggedInUser;

        public UsersListView(HandleUsers handleUsers, User loggedInUser)
        {
            InitializeComponent();
            this.handleUsers = handleUsers;
            this.loggedInUser = loggedInUser;

            List<User> users = handleUsers.users;
            tbDisplayAllUsers.Items.Clear();
            foreach (User user in users)
            {
                tbDisplayAllUsers.Items.Add(user.ToString());
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserView addUserView = new AddUserView(handleUsers, loggedInUser);
            addUserView.Show();
            this.Close();
        }

        private void btnBackToAdminView_Click(object sender, EventArgs e)
        {
            AdminView adminView = new AdminView(handleUsers, loggedInUser);
            adminView.Show();
            this.Close();
        }
    }
}

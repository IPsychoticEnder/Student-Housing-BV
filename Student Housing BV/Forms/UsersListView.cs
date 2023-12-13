using Student_Housing_BV.Classes;

namespace Student_Housing_BV.Forms
{
    public partial class UsersListView : Form
    {
        HandleUsers handleUsers;
        public UsersListView(HandleUsers handleUsers)
        {
            InitializeComponent();
            this.handleUsers = handleUsers;
            List<User> users = handleUsers.users;
            tbDisplayAllUsers.Items.Clear();
            foreach (User user in users)
            {
                tbDisplayAllUsers.Items.Add(user.ToString());
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserView addUserView = new AddUserView(handleUsers);
            addUserView.Show();
            this.Close();
        }

        private void btnBackToAdminView_Click(object sender, EventArgs e)
        {
            AdminView adminView = new AdminView(handleUsers);
            adminView.Show();
            this.Close();
        }

        private void btnRefreshPage_Click(object sender, EventArgs e)
        {
            tbDisplayAllUsers.Items.Clear();
            foreach (User user in handleUsers.users) 
            {
                tbDisplayAllUsers.Items.Add(user.ToString());
            }
        }
    }
}

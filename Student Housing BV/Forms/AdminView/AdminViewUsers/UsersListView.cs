using Student_Housing_BV.Classes.Users;
using Student_Housing_BV.Forms.UsersView;

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


            List<User> users = handleUsers.Users;
            dataGridDisplayAllUsers.DataSource = users;

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserView addUserView = new(handleUsers, loggedInUser);
            addUserView.Show();
            this.Hide();
        }

        private void btnBackToAdminView_Click(object sender, EventArgs e)
        {
            AdminViewMainPage adminView = new(handleUsers, loggedInUser);
            adminView.Show();
            this.Close();
        }

        private void dataGridDisplayAllUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            User selectedUser = (User)dataGridDisplayAllUsers.SelectedRows[0].DataBoundItem;
            EditUserView editUserView = new(handleUsers, loggedInUser, selectedUser);
            editUserView.Show();
            this.Hide();
        }
    }
}

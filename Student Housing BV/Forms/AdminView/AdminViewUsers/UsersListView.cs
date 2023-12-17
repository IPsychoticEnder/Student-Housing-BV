using Student_Housing_BV.Classes;
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
            foreach (User user in users)
            {
                dataGridDisplayAllUsers.DataSource = users;
            }
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

        private void dtgridDisplayAllUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int userID = e.RowIndex;

            EditUserView editUserView = new(handleUsers, loggedInUser, userID);
            editUserView.Show();
            this.Hide();
        }
    }
}

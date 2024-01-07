using Student_Housing_BV.Classes.Users;
using Student_Housing_BV.Forms.UsersView;

namespace Student_Housing_BV.Forms
{
    public partial class UsersListView : Form
    {
        HandleUsers HandleUsers;
        User LoggedInUser;

        public UsersListView(HandleUsers handleUsers, User loggedInUser)
        {
            InitializeComponent();
            HandleUsers = handleUsers;
            LoggedInUser = loggedInUser;

            //gets the list of users from the HandleUsers that was passed throught AdminViewHomePage
            //Sets the data inside the dataGrid to that of the list.
            List<User> users = handleUsers.Users;
            dataGridDisplayAllUsers.DataSource = users;

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            /*This button redirects you to the AddUserView Form. to work properly it requires HandleUsers and LoggedInUser
            which was passed through just like a variable in a class through a consturctor*/
            AddUserView addUserView = new(HandleUsers, LoggedInUser);
            addUserView.Show();
            this.Hide();
        }

        private void btnBackToAdminView_Click(object sender, EventArgs e)
        {
            /*This button redirects you back to the AdminView Form. to work properly it requires HandleUsers and LoggedInUser
            which was passed through just like a variable in a class through a consturctor*/
            AdminViewMainPage adminView = new(HandleUsers, LoggedInUser);
            adminView.Show();
            this.Close();
        }

        private void dataGridDisplayAllUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*This returns item of the row you clicked in the DataGrid.
            Once you double click on a user in the DataGrid it Creates the selectedUser variable and sets it to the content of the user you clicked
            
            After that it opens the EditUserView form in which in passes through the corresponding variables similar to
            a constructor in a class*/
            User selectedUser = (User)dataGridDisplayAllUsers.SelectedRows[0].DataBoundItem;
            EditUserView editUserView = new(HandleUsers, LoggedInUser, selectedUser);
            editUserView.Show();
            this.Hide();
        }
    }
}

using Student_Housing_BV.Classes;

namespace Student_Housing_BV
{
    public partial class LoginView : Form
    {
        HandleUsers users = new HandleUsers();
        HandleUsers handleUsers = new HandleUsers();

        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbLoginUserID.Text;
            string password = tbLoginUserPassword.Text;

            User toBeValidatedUser = new User(userName, -1, password, false);
            User validatedUser = users.ValidateUser(toBeValidatedUser);

            if (validatedUser != null)
            {
                if (validatedUser.isAdmin)
                {
                    AdminView adminView = new AdminView(handleUsers);
                    adminView.Show();
                    this.Hide();
                }
                else
                {
                    StudentView studentView = new StudentView(validatedUser);
                    studentView.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please make sure your login information is correct");
            }
        }
    }
}
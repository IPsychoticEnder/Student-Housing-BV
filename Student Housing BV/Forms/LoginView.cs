using Student_Housing_BV.Classes;

namespace Student_Housing_BV
{
    public partial class LoginView : Form
    {
        readonly HandleUsers users = new();
        readonly HandleUsers handleUsers = new();

        public LoginView()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbLoginUserID.Text;
            string password = tbLoginUserPassword.Text;

            User toBeValidatedUser = new(userName, -1, password, false);
            User validatedUser = users.ValidateUser(toBeValidatedUser);

            if (validatedUser != null)
            {
                if (validatedUser.IsAdmin)
                {
                    AdminView adminView = new(handleUsers, validatedUser);
                    adminView.Show();
                    this.Hide();
                }
                else
                {
                    StudentView studentView = new(validatedUser);
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
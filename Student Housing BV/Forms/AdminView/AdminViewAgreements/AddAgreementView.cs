using Student_Housing_BV.Classes.Agreements;
using Student_Housing_BV.Classes.Users;


namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    public partial class AddAgreementView : Form
    {
        HandleAgreements HandleAgreements;
        HandleUsers HandleUsers;
        User LoggedInUser;


        public AddAgreementView(HandleUsers handleUsers, User loggedInUser, HandleAgreements handleAgreements)
        {
            InitializeComponent();
            this.HandleAgreements = handleAgreements;
            this.HandleUsers = handleUsers;
            this.LoggedInUser = loggedInUser;
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            string Title = tbNewAgreementTitle.Text;
            string Description = tbNewAgreementDescription.Text;

            Agreement newAgreement = new(Title, Description);

            HandleAgreements.AddAgreement(newAgreement);

            AgreementsListView agreementsListView = new(HandleUsers, LoggedInUser);
            agreementsListView.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AgreementsListView agreementsListView = new(HandleUsers, LoggedInUser);
            agreementsListView.Show();
            this.Close();
        }
    }
}

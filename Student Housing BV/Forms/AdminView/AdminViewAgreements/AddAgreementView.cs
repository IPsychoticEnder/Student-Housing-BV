using Student_Housing_BV.Classes.Agreements;
using Student_Housing_BV.Classes.Users;


namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    public partial class AddAgreementView : Form
    {
        public HandleAgreements HandleAgreements { get; set; }
        public HandleUsers HandleUsers { get; set; }
        public User LoggedInUser { get; set; }


        public AddAgreementView(HandleUsers handleUsers, User loggedInUser, HandleAgreements handleAgreements)
        {
            InitializeComponent();
            HandleAgreements = handleAgreements;
            HandleUsers = handleUsers;
            LoggedInUser = loggedInUser;
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            //Adds a new agreement through the HandleAgreements class
            string Title = tbNewAgreementTitle.Text;
            string Description = tbNewAgreementDescription.Text;

            Agreement newAgreement = new(Title, Description);

            HandleAgreements.AddAgreement(newAgreement);

            AgreementsListView AgreementsListView = new(HandleUsers, LoggedInUser);
            AgreementsListView.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Redirects the user back to the AgreementListView
            AgreementsListView AgreementsListView = new(HandleUsers, LoggedInUser);
            AgreementsListView.Show();
            this.Close();
        }
    }
}

using Student_Housing_BV.Classes.Agreements;
using Student_Housing_BV.Classes.Users;


namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    public partial class EditAgreementView : Form
    {
        HandleUsers handleUsers;
        HandleAgreements handleAgreements;
        User loggedInUser;
        Agreement selectedAgreement;

        public EditAgreementView(HandleUsers handleUsers, User loggedInUser, HandleAgreements handleAgreements, Agreement selectedAgreement)
        {
            InitializeComponent();

            this.handleUsers = handleUsers;
            this.handleAgreements = handleAgreements;
            this.loggedInUser = loggedInUser;
            this.selectedAgreement = selectedAgreement;

            tbAgreementTitle.Text = selectedAgreement.Title;
            tbAgreementDescription.Text = selectedAgreement.Description;
        }

        private void btnSaveAgreement_Click(object sender, EventArgs e)
        {
            string newTitle = tbAgreementTitle.Text;
            string newDescription = tbAgreementDescription.Text;

            Agreement newAgreement = new(newTitle, newDescription);

            handleAgreements.EditAgreement(selectedAgreement, newAgreement);
            AgreementsListView agreementsListView = new(handleUsers, loggedInUser);
            agreementsListView.Show();
            this.Close();
        }

        private void btnDeleteAgreement_Click(object sender, EventArgs e)
        {
            handleAgreements.RemoveAgreement(selectedAgreement);
            AgreementsListView agreementsListView = new(handleUsers, loggedInUser);
            agreementsListView.Show();
            this.Close();
        }
    }
}

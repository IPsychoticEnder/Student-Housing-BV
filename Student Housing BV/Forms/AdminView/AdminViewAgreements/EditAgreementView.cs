using Student_Housing_BV.Classes.Agreements;
using Student_Housing_BV.Classes.Users;


namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    public partial class EditAgreementView : Form
    {
        HandleUsers HandleUsers;
        HandleAgreements HadnleAgreement;
        User LoggedInUser;
        Agreement SelectedAgreement;

        public EditAgreementView(HandleUsers handleUsers, User loggedInUser, HandleAgreements handleAgreements, Agreement selectedAgreement)
        {
            InitializeComponent();

            HandleUsers = handleUsers;
            HadnleAgreement = handleAgreements;
            LoggedInUser = loggedInUser;
            SelectedAgreement = selectedAgreement;

            //Populates the form with the existing content of the Agreement which is being edited.
            tbAgreementTitle.Text = selectedAgreement.Title;
            tbAgreementDescription.Text = selectedAgreement.Description;
        }

        private void btnSaveAgreement_Click(object sender, EventArgs e)
        {
            //Creates a newAgreement object then saves it to the list through HandleAgreements
            string newTitle = tbAgreementTitle.Text;
            string newDescription = tbAgreementDescription.Text;

            Agreement newAgreement = new(newTitle, newDescription);

            HadnleAgreement.EditAgreement(SelectedAgreement, newAgreement);
            AgreementsListView agreementsListView = new(HandleUsers, LoggedInUser);
            agreementsListView.Show();
            this.Close();
        }

        private void btnDeleteAgreement_Click(object sender, EventArgs e)
        {
            //Deletes the Agreement object through the HandleAgreements clas
            //Maybe add some extra validation i.e "Are you sure you want to delete this Agreement?"
            HadnleAgreement.RemoveAgreement(SelectedAgreement);
            AgreementsListView agreementsListView = new(HandleUsers, LoggedInUser);
            agreementsListView.Show();
            this.Close();
        }
    }
}

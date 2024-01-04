using Student_Housing_BV.Classes.Agreements;
using Student_Housing_BV.Classes.Users;


namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    public partial class AgreementsListView : Form
    {
        HandleUsers HandleUsers;
        User LoggedInUser;
        HandleAgreements HandleAgreements = new();
        List<Agreement> Agreements = new();


        public AgreementsListView(HandleUsers handleUsers, User loggedInUser)
        {
            InitializeComponent();
            HandleUsers = handleUsers;
            LoggedInUser = loggedInUser;

            Agreements = HandleAgreements.Agreements;
            dataGridDisplayAllAgreements.DataSource = Agreements;
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            AddAgreementView addAgreementView = new(HandleUsers, LoggedInUser, HandleAgreements);
            addAgreementView.Show();
            this.Hide();
        }

        private void btnBackToAdminView_Click(object sender, EventArgs e)
        {
            AdminViewMainPage adminViewMainPage = new(HandleUsers, LoggedInUser);
            adminViewMainPage.Show();
            this.Close();
        }

        private void dataGridDisplayAllAgreements_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Agreement selectedAgreement = (Agreement)dataGridDisplayAllAgreements.SelectedRows[0].DataBoundItem;
            EditAgreementView editAgreementView = new(HandleUsers, LoggedInUser, HandleAgreements,selectedAgreement);
            editAgreementView.Show();
            this.Hide();
        }
    }
}

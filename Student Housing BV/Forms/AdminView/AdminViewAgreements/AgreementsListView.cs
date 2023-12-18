using Student_Housing_BV.Classes;


namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    public partial class AgreementsListView : Form
    {
        HandleUsers handleUsers = new();
        User loggedInUser;

        HandleAgreements handleAgreements = new();
        List<Agreement> agreements = new();


        public AgreementsListView(HandleUsers handleUsers, User loggedInUser)
        {
            InitializeComponent();
            this.handleUsers = handleUsers;
            this.loggedInUser = loggedInUser;

            agreements = handleAgreements.Agreements;
            dataGridDisplayAllAgreements.DataSource = agreements;
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            AddAgreementView addAgreementView = new(handleUsers, loggedInUser, handleAgreements);
            addAgreementView.Show();
            this.Hide();
        }

        private void btnBackToAdminView_Click(object sender, EventArgs e)
        {
            AdminViewMainPage adminViewMainPage = new(handleUsers, loggedInUser);
            adminViewMainPage.Show();
            this.Close();
        }

        private void dataGridDisplayAllAgreements_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

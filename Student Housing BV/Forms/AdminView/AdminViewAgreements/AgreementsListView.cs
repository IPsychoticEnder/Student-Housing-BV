using Student_Housing_BV.Classes.Agreements;
using Student_Housing_BV.Classes.Users;


namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    public partial class AgreementsListView : Form
    {
        HandleUsers HandleUsers;
        User LoggedInUser;
        HandleAgreements HandleAgreements { get; set; }
        List<Agreement> Agreements { get; set; }

        public AgreementsListView(HandleUsers handleUsers, User loggedInUser)
        {
            InitializeComponent();
            HandleUsers = handleUsers;
            LoggedInUser = loggedInUser;
            HandleAgreements = new();
            
            /*Populates the list of agreements with the list that was retrieved from HandleAgreements.
             Databinds the DataGrid with the list of agreements*/
            Agreements = HandleAgreements.Agreements;
            dataGridDisplayAllAgreements.DataSource = Agreements;
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            //Routes the user to the AddAgreementView passing through HandleUsers, LoggedInUser and HandleAgreements.
            AddAgreementView AddAgreementView = new(HandleUsers, LoggedInUser, HandleAgreements);
            AddAgreementView.Show();
            this.Hide();
        }

        private void btnBackToAdminView_Click(object sender, EventArgs e)
        {
            //Routes the user back ti AdminViewMainPage
            AdminViewMainPage adminViewMainPage = new(HandleUsers, LoggedInUser);
            adminViewMainPage.Show();
            this.Close();
        }

        private void dataGridDisplayAllAgreements_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*This returns item of the row you clicked in the DataGrid.
            Once you double click on a Agreement in the DataGrid it Creates the SelectedAgreement variable and sets it to the content
            of the Agreement you clicked.
            
            After that it opens the EditAgreementView form in which in passes through the corresponding variables similar to
            a constructor in a class*/
            Agreement selectedAgreement = (Agreement)dataGridDisplayAllAgreements.SelectedRows[0].DataBoundItem;
            EditAgreementView editAgreementView = new(HandleUsers, LoggedInUser, HandleAgreements,selectedAgreement);
            editAgreementView.Show();
            this.Hide();
        }
    }
}

using Student_Housing_BV.Classes;


namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    public partial class AddAgreementView : Form
    {
        HandleAgreements HandleAgreements {  get; set; }
        HandleUsers HandleUsers { get; set; }
        User LoggedInUser { get; set; }

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

            HandleAgreements.AddAgreement(Title, Description);

            AgreementsListView agreementsListView = new(HandleUsers, LoggedInUser);
            agreementsListView.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}

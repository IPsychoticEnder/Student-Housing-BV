using Student_Housing_BV.Classes;


namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    public partial class AddAgreementView : Form
    {
        HandleAgreements HandleAgreements {  get; set; }

        public AddAgreementView(HandleAgreements handleAgreements)
        {
            InitializeComponent();
            this.HandleAgreements = handleAgreements;
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            string Title = tbNewAgreementTitle.Text;
            string Description = tbNewAgreementDescription.Text;

            HandleAgreements.AddAgreement(Title, Description);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}

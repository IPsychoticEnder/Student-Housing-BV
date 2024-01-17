using Student_Housing_BV.Classes.StudentAgreements;

namespace Student_Housing_BV.Forms.AdminView.AdminViewStudentAgreements
{
    public partial class StudentAgreementListView : Form
    {
        public HandleStudentAgreements HandleStudentAgreements { get; private set; }
        public Form PrevForm { get; private set; }

        public StudentAgreementListView(Form prevForm)
        {
            InitializeComponent();
            HandleStudentAgreements = new();
     
            this.PrevForm = prevForm;

            if (HandleStudentAgreements.StudentAgreements != null)
            {
                foreach (var agreement in HandleStudentAgreements.StudentAgreements)
                {
                    string displayInfo = $"AGREEMENT:  {agreement.Key}.     STUDENTS:  ";
                    foreach (var user in agreement.Value)
                    {
                        displayInfo = $"{displayInfo}|  {user.UserName}  ";
                    }
                    lbDisplayAllStudentAgreement.Items.Add(displayInfo);
                }
            }
        }

        private void btnBackToAdminView_Click(object sender, EventArgs e)
        {
            PrevForm.Show();
            this.Close();
        }

        private void btnStudentAgreement_Click(object sender, EventArgs e)
        {
            AddStudentAgreementView form = new(this, HandleStudentAgreements);
            form.Show();
            this.Hide();
        }
    }
}

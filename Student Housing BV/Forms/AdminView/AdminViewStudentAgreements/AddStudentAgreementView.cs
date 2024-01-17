using Student_Housing_BV.Classes.StudentAgreements;
using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV.Forms.AdminView.AdminViewStudentAgreements
{
    public partial class AddStudentAgreementView : Form
    {
        private HandleUsers HandleUsers = new();
        private HandleStudentAgreements HandleStudentAgreements;
        private Form PrevForm;
        private List<ComboBox> cbBoxes = new();


        public AddStudentAgreementView(Form prevForm, HandleStudentAgreements handleStudentAgreements)
        {
            InitializeComponent();
            HandleStudentAgreements = handleStudentAgreements;
            PrevForm = prevForm;

            ComboBox cbb = new()
            {
                DataSource = HandleUsers.Users.Where(user => !user.IsAdmin).ToList(),
                DisplayMember = "UserName"
            };
            cbBoxes.Add(cbb);
            AddcbbToFlowPanel();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PrevForm.Show();
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (cbBoxes.Count == (HandleUsers.Users.Where(user => !user.IsAdmin).ToList()).Count)
            {
                MessageBox.Show("Reached the max ammount of users");
            }
            else
            {
                ComboBox cbb = new()
                {
                    DataSource = HandleUsers.Users.Where(user => !user.IsAdmin).ToList(),
                    DisplayMember = "UserName"
                };
                cbBoxes.Add(cbb);
                AddcbbToFlowPanel();
            }
        }

        private void AddcbbToFlowPanel()
        {
            flowPanelDisplayUsers.Controls.Clear();
            foreach (var cbb in cbBoxes)
            {
                flowPanelDisplayUsers.Controls.Add(cbb);
            }
        }

        private void btnSaveStudentAgreement_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text == "")
            {
                MessageBox.Show("Please fill out all fields");
            }
            else 
            {
                string description = tbDescription.Text;
                List<User> studentsInAgreement = new();
                foreach (var cbb in cbBoxes)
                {
                    studentsInAgreement.Add((User)cbb.SelectedItem);
                }

                HandleStudentAgreements.AddNewStudentAgreement(description, studentsInAgreement);
                PrevForm.Show();
                this.Close();
            }
        }
    }
}

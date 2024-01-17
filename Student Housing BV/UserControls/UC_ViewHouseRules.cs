
using Student_Housing_BV.Classes.Agreements;
using Student_Housing_BV.UserControls.Components;

namespace Student_Housing_BV.UserControls
{
    public partial class UC_ViewHouseRules : UserControl
    {
        private HandleAgreements HandleAgreements;

        public UC_ViewHouseRules()
        {
            InitializeComponent();
            HandleAgreements = new();

            foreach (var agreement in HandleAgreements.Agreements)
            {
                DisplayHouseRulesComponent uc = new(agreement);
                flowpanelDisplayHouseRules.Controls.Add(uc);
            }
        }
    }
}

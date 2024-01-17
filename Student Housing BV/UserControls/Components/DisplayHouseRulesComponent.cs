
using Student_Housing_BV.Classes.Agreements;

namespace Student_Housing_BV.UserControls.Components
{
    public partial class DisplayHouseRulesComponent : UserControl
    {
        public DisplayHouseRulesComponent(Agreement agreement)
        {
            InitializeComponent();
            tbDisplayRuleTitle.Text = agreement.Title;
            tbDisplayRuleDescription.Text = agreement.Description;
        }
    }
}

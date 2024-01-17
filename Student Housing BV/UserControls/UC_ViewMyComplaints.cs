using Student_Housing_BV.Classes.Complaints;
using Student_Housing_BV.UserControls.Components;

namespace Student_Housing_BV.UserControls
{
    public partial class UC_ViewMyComplaints : UserControl
    {

        public UC_ViewMyComplaints(List<Complaint> myComplaints)
        {
            InitializeComponent();

            foreach (var complaint in myComplaints)
            {
                DisplayComplaintComponent component = new(complaint);
                FlowpanelDisplayComplaints.Controls.Add(component);
            }
        }
    }
}

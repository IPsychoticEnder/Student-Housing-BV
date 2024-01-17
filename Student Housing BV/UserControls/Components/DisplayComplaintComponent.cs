using Student_Housing_BV.Classes.Complaints;

namespace Student_Housing_BV.UserControls.Components
{
    public partial class DisplayComplaintComponent : UserControl
    {
        public DisplayComplaintComponent(Complaint complaint)
        {
            InitializeComponent();
            lbDisplayDate.Text = $"{complaint.DayOfComplaint}";
            lbDisplayComplaint.Text = complaint.ComplaintDescription;
        }
    }
}

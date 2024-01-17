
using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV.Classes.Complaints
{
    public class Complaint
    {
        public User Complainant { get; private set; }
        public User Accused { get; private set; }
        public string ComplaintDescription { get; private set; }
        public DateTime DayOfComplaint { get; private set; }

        public Complaint(User complainant, User accused, string complaintDescription)
        {
            Complainant = complainant;
            Accused = accused;
            ComplaintDescription = complaintDescription;
            DayOfComplaint = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{DayOfComplaint} \n\n" +
                $"From User: {Complainant.UserName}  |  To User: {Accused.UserName}\n\n" +
                $"Complaint:\n" +
                $"{ComplaintDescription}";
        }
    }
}

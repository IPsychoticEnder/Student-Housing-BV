using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV.Classes.StudentAgreements
{
    public class StudentAgreement
    {
        public string Agreement {  get; private set; }
        public List<User> StudentsInAgreement { get; private set; }

        public StudentAgreement(string agreement, List<User> studentsInAgreement)
        {
            Agreement = agreement;
            StudentsInAgreement = studentsInAgreement;
        }
    }
}

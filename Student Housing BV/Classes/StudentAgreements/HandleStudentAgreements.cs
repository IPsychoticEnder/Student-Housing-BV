
using Newtonsoft.Json;
using Student_Housing_BV.Classes.Users;

namespace Student_Housing_BV.Classes.StudentAgreements
{
    public class HandleStudentAgreements
    {
        public Dictionary<string, List<User>> StudentAgreements {  get; private set; }
        private string FilePath;

        public HandleStudentAgreements()
        {
            StudentAgreements = new Dictionary<string, List<User>>();

            string relativeFilepath = "\\Data\\Json\\StudentAgreements.json";
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            while (!currentDirectory.EndsWith("\\Student Housing BV"))
            {
                currentDirectory = Directory.GetParent(currentDirectory).FullName;
            }

            FilePath = $"{currentDirectory}{relativeFilepath}";
            ReadFromJson();
        }

        public void AddNewStudentAgreement(string description, List<User> studentsInAgreement)
        {
            StudentAgreements.Add(description, studentsInAgreement);
            WriteToJson();
        }

        public void WriteToJson()
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(StudentAgreements, Formatting.Indented);
                File.WriteAllText(FilePath, jsonContent);
                Console.WriteLine($"Data succesfully written to: {FilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurd: {ex.Message}");
            }
        }

        public void ReadFromJson()
        {
            try
            {
                string jsonContent = File.ReadAllText(FilePath);

                StudentAgreements = JsonConvert.DeserializeObject<Dictionary<string, List<User>>>(jsonContent);
                Console.WriteLine($"Succesfully read from: {FilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurd: {ex.Message}");
            }
        }
    }
}

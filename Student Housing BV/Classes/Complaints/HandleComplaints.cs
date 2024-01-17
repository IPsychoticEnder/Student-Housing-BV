using Newtonsoft.Json;

namespace Student_Housing_BV.Classes.Complaints
{
    public class HandleComplaints
    {
        public List<Complaint> Complaints { get; private set; }
        private string FilePath;

        public HandleComplaints() 
        {
            Complaints = new();

            string relativeFilepath = "\\Data\\Json\\Complaints.json";
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            while (!currentDirectory.EndsWith("\\Student Housing BV"))
            {
                currentDirectory = Directory.GetParent(currentDirectory).FullName;
            }
            FilePath = $"{currentDirectory}{relativeFilepath}";

            ReadFromJson();
        }

        public void AddComplaint(Complaint newComplaint)
        {
            Complaints.Add(newComplaint);
            WriteToJson();
        }

        public void ReadFromJson()
        {
            try
            {
                string jsonContent = File.ReadAllText(FilePath);

                Complaints = JsonConvert.DeserializeObject<List<Complaint>>(jsonContent);
                Console.WriteLine($"Succesfully read from: {FilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurd: {ex.Message}");
            }
        }

        public void WriteToJson()
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(Complaints, Formatting.Indented);
                File.WriteAllText(FilePath, jsonContent);
                Console.WriteLine($"Data succesfully written to: {FilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurd: {ex.Message}");
            }
        }
    }
}

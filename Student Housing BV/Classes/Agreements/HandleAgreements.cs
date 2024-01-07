using Newtonsoft.Json;


namespace Student_Housing_BV.Classes.Agreements
{
    public class HandleAgreements
    {
        public List<Agreement> Agreements { get; private set; }
        public string FilePath { get; private set; }


        public HandleAgreements()
        {
            Agreements = new List<Agreement>();

            /*This piece of code grabs the source of the file, goes back untill it reaches where all the folders 
             are saved i.e Student Housing BV.

             Once it finds the right file it routes to the Agreements.json file.*/
            string relativeFilepath = "\\Data\\Json\\Agreements.json";
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            while (!currentDirectory.EndsWith("\\Student Housing BV"))
            {
                currentDirectory = Directory.GetParent(currentDirectory).FullName;
            }
            FilePath = $"{currentDirectory}{relativeFilepath}";

            ReadFromJson();
        }


        /*Method to add a new Agreement to the agreements list.*/
        public void AddAgreement(string Title, string Description)
        {
            Agreement newAgreement = new(Title, Description);

            Agreements.Add(newAgreement);
            WriteToJson();
        }

        public void EditAgreement(Agreement oldAgreement, Agreement newAgreement)
        {
            Agreements[Agreements.IndexOf(oldAgreement)] = newAgreement;
            WriteToJson();
        }

        public void RemoveAgreement(Agreement removeAgreement)
        {
            Agreements.Remove(removeAgreement);
            WriteToJson();
        }

        public void ReadFromJson()
        {
            try
            {
                string jsonContent = File.ReadAllText(FilePath);

                Agreements = JsonConvert.DeserializeObject<List<Agreement>>(jsonContent);
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
                string jsonContent = JsonConvert.SerializeObject(Agreements, Formatting.Indented);
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

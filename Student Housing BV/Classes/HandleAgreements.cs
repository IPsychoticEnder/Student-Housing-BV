using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_BV.Classes
{
    internal class HandleAgreements
    {
        public List<Agreement> Agreements { get; private set; }
        public string FilePath { get; private set; }
        

        public HandleAgreements() 
        {
            Agreements = new List<Agreement>();

            string relativeFilepath = "\\Data\\Json\\Agreements.json";
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            while (!currentDirectory.EndsWith("\\Student Housing BV"))
            {
                currentDirectory = Directory.GetParent(currentDirectory).FullName;
            }
            this.FilePath = $"{currentDirectory}{relativeFilepath}";

            ReadFromJson();

        }

        public void AddAgreement(Agreement newAgreement)
        {

        }

        public void ReadFromJson()
        {
            try
            {
                string jsonContent = File.ReadAllText(FilePath);

                this.Agreements = JsonConvert.DeserializeObject<List<Agreement>>(jsonContent);
                Console.WriteLine($"Succesfully read from: {FilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurd: {ex.Message}");
            }
        }
    }
}

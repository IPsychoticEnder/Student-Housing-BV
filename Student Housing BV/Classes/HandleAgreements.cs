using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_BV.Classes
{
    public class HandleAgreements
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

        public void AddAgreement(string Title, string Description)
        {
            int ID = 0;
            if (Agreements.Count > 0)
            {
                ID = Agreements.Last().ID + 1;
            }

            Agreement newAgreement = new(Title, Description, ID);

            Agreements.Add(newAgreement);
            WriteToJson();
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

using Newtonsoft.Json;

namespace Student_Housing_BV.Classes.Tasks
{
    public class HandleTasks
    {
        public List<Task> Tasks {  get; private set; }
        public string FilePath { get; private set; }


        public HandleTasks() 
        {
            Tasks = new List<Task>();
            string relativeFilepath = "\\Data\\Json\\Tasks.json";
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            while (!currentDirectory.EndsWith("\\Student Housing BV"))
            {
                currentDirectory = Directory.GetParent(currentDirectory).FullName;
            }
            FilePath = $"{currentDirectory}{relativeFilepath}";

            ReadFromJson();
        }

        public void AddTask(Task newTask)
        {
            Tasks.Add(newTask);
            WriteToJson();
        }

        public void EditTask(Task oldTask, Task newTask)
        {
            Tasks[Tasks.IndexOf(oldTask)] = newTask;
            WriteToJson();
        }

        public void RemoveTask(Task removeTask)
        {
            Tasks.Remove(removeTask);
            WriteToJson();
        }

        public void ReadFromJson()
        {
            try
            {
                string jsonContent = File.ReadAllText(FilePath);

                Tasks = JsonConvert.DeserializeObject<List<Task>>(jsonContent);
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
                string jsonContent = JsonConvert.SerializeObject(Tasks, Formatting.Indented);
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

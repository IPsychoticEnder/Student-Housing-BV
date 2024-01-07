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

            /*This piece of code grabs the source of the file, goes back untill it reaches where all the folders 
             are saved i.e Student Housing BV.

             Once it finds the right file it routes to the Tasks.json file.*/
            string relativeFilepath = "\\Data\\Json\\Tasks.json";
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            while (!currentDirectory.EndsWith("\\Student Housing BV"))
            {
                currentDirectory = Directory.GetParent(currentDirectory).FullName;
            }
            FilePath = $"{currentDirectory}{relativeFilepath}";

            ReadFromJson();
        }

        //Method to add new task to the Tasks list
        public void AddTask(Task newTask)
        {
            Tasks.Add(newTask);
            WriteToJson();
        }

        //method to edit an exitsing tast in the Tasks list
        public void EditTask(Task oldTask, Task newTask)
        {
            Tasks[Tasks.IndexOf(oldTask)] = newTask;
            WriteToJson();
        }

        //method to remove a task completely from the list
        public void RemoveTask(Task removeTask)
        {
            Tasks.Remove(removeTask);
            WriteToJson();
        }

        //reads the json file and saves in in the Tasks list
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

        //stores the tasks list in a json file
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

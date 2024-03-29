using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTodoList.Model
{
    internal class FileTasks
    {
        private static string filePath = "tasks.json";

        public static void FileTaskWrite(ObservableCollection<ToDoTask> tasks)
        {
            string jsonData = JsonConvert.SerializeObject(tasks);
            File.WriteAllText(filePath, jsonData);
        }

        public static ObservableCollection<ToDoTask> FileTaskRead()
        {
            ObservableCollection<ToDoTask> tasks = new ObservableCollection<ToDoTask>();

            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                tasks = JsonConvert.DeserializeObject<ObservableCollection<ToDoTask>>(jsonData);
            }

            return tasks;
        }
    }
}

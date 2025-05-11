using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TaskManager
{
    public class TaskStorage
    {
        private readonly string filePath = "tasks.json";

        public void SaveTasks(List<Task> tasks)
        {
            var json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public List<Task> LoadTasks()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Task>>(json) ?? new List<Task>();
            }
            return new List<Task>();
        }
    }
}
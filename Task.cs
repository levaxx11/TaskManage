using System;
namespace TaskManager
{
    public enum TaskPriority
    {
        Low, Medium, High
    }
    public enum TaskStatus
    {
        NotStarted, InProgress, Completed
    }
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskPriority Priority { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public Task (int id, string title, string description, TaskPriority priority, TaskStatus status)
        {
            Id = id;
            Title = title;
            Description = description;
            Priority = priority;
            Status = status;
            CreatedAt = DateTime.Now;
        }
    }
    
}
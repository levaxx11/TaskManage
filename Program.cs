using System;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new TaskManager();

            while (true)
            {
                Console.WriteLine("\nTask Manager");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Edit Task");
                Console.WriteLine("3. Delete Task");
                Console.WriteLine("4. List All Tasks");
                Console.WriteLine("5. Filter Tasks by Status");
                Console.WriteLine("6. Filter Tasks by Priority");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter description: ");
                        string desc = Console.ReadLine();
                        Console.Write("Enter priority (0=Low, 1=Medium, 2=High): ");
                        if (Enum.TryParse(Console.ReadLine(), out TaskPriority priority))
                            manager.AddTask(title, desc, priority);
                        else
                            Console.WriteLine("Invalid priority!");
                        break;

                    case "2":
                        Console.Write("Enter task ID: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.Write("Enter new title: ");
                            title = Console.ReadLine();
                            Console.Write("Enter new description: ");
                            desc = Console.ReadLine();
                            Console.Write("Enter new priority (0=Low, 1=Medium, 2=High): ");
                            if (Enum.TryParse(Console.ReadLine(), out priority))
                            {
                                Console.Write("Enter new status (0=ToDo, 1=InProgress, 2=Done): ");
                                if (Enum.TryParse(Console.ReadLine(), out TaskStatus status))
                                    manager.EditTask(id, title, desc, priority, status);
                                else
                                    Console.WriteLine("Invalid status!");
                            }
                            else
                                Console.WriteLine("Invalid priority!");
                        }
                        else
                            Console.WriteLine("Invalid ID!");
                        break;

                    case "3":
                        Console.Write("Enter task ID: ");
                        if (int.TryParse(Console.ReadLine(), out id))
                            manager.DeleteTask(id);
                        else
                            Console.WriteLine("Invalid ID!");
                        break;

                    case "4":
                        manager.ListTasks();
                        break;

                    case "5":
                        Console.Write("Enter status to filter (0=ToDo, 1=InProgress, 2=Done): ");
                        if (Enum.TryParse(Console.ReadLine(), out TaskStatus filterStatus))
                            manager.ListTasks(statusFilter: filterStatus);
                        else
                            Console.WriteLine("Invalid status!");
                        break;

                    case "6":
                        Console.Write("Enter priority to filter (0=Low, 1=Medium, 2=High): ");
                        if (Enum.TryParse(Console.ReadLine(), out TaskPriority filterPriority))
                            manager.ListTasks(priorityFilter: filterPriority);
                        else
                            Console.WriteLine("Invalid priority!");
                        break;

                    case "7":
                        return;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }
    }
}
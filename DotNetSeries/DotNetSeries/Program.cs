using DotNetSeries.Enums;
using DotNetSeries.Services;

class Program
{
    static void Main(string[] args)
    {
        var taskManager = new TaskManager();

        int menuItem = 0;
        while (menuItem != 7)
        {
            Console.WriteLine("\nTask Manager\n");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Search task");
            Console.WriteLine("4. Mark tasks as completed");
            Console.WriteLine("5. Delete Task");
            Console.WriteLine("6. View upcoming tasks due");
            Console.WriteLine("7. Exit");

            Console.Write("\nSelect an option: ");

            if (!int.TryParse(Console.ReadLine(), out menuItem) || menuItem < 1 || menuItem > 7)
            {
                Console.WriteLine("Invalid option, please try again.");
                continue;
            }

            Console.Clear();

            switch (menuItem)
            {
                case 1:
                    Console.Write("Enter task name: ");
                    string name = Console.ReadLine() ?? $"Task";
                    Console.Write("Enter task description: ");
                    string description = Console.ReadLine() ?? "No description provided.";

                    Console.Write("Enter task priority (0: Low, 1: Medium, 2: High): ");
                    int priorityInput;
                    while (!int.TryParse(Console.ReadLine(), out priorityInput) || priorityInput < 0 || priorityInput > 2)
                        Console.Write("Invalid input. Enter 0, 1, or 2: ");

                    Console.Write("Enter task due date (yyyy-MM-dd): ");
                    DateTime dueDate;
                    while (!DateTime.TryParse(Console.ReadLine(), out dueDate) || dueDate < DateTime.Now)
                        Console.Write("Invalid date. Enter again (yyyy-MM-dd): ");

                    taskManager.AddTask(name, description, (Priority)priorityInput, dueDate);
                    break;

                case 2:
                    var allTasks = taskManager.GetAllTasks();
                    if (allTasks.Count == 0)
                    {
                        Console.WriteLine("No tasks available.");
                    }
                    else
                    {
                        foreach (var task in allTasks)
                        {
                            task.Display();
                        }
                    }
                    break;

                case 3:
                    Console.Write("Search task by (0: Status, 1: Priority): ");
                    int searchOption;
                    while (!int.TryParse(Console.ReadLine(), out searchOption) || (searchOption != 0 && searchOption != 1))
                        Console.Write("Invalid input. Enter 0 or 1: ");

                    if (searchOption == 0)
                    {
                        Console.Write("Choose a status (0: Pending, 1: InProgress, 2: Completed): ");
                        int statusInput;
                        while (!int.TryParse(Console.ReadLine(), out statusInput) || statusInput < 0 || statusInput > 2)
                            Console.Write("Invalid input. Enter 0, 1, or 2: ");

                        var byStatus = taskManager.SearchByStatus((Status)statusInput);
                        if (byStatus.Count == 0)
                            Console.WriteLine("No tasks with that status.");
                        else
                            foreach (var task in byStatus)
                            {
                                task.Display();
                            }
                    }
                    else
                    {
                        Console.Write("Choose a priority (0: Low, 1: Medium, 2: High): ");
                        int prioInput;
                        while (!int.TryParse(Console.ReadLine(), out prioInput) || prioInput < 0 || prioInput > 2)
                            Console.Write("Invalid input. Enter 0, 1, or 2: ");

                        var byPriority = taskManager.SearchByPriority((Priority)prioInput);
                        if (byPriority.Count == 0)
                            Console.WriteLine("No tasks with that priority.");
                        else
                            foreach (var task in byPriority)
                            {
                                task.Display();
                            }
                    }
                    break;

                case 4:
                    Console.Write("Enter task ID to mark as completed: ");
                    if (int.TryParse(Console.ReadLine(), out int completeId) && taskManager.MarkTaskAsCompleted(completeId))
                        Console.WriteLine("Task marked as completed.");
                    else
                        Console.WriteLine("Invalid ID.");
                    break;

                case 5:
                    Console.Write("Enter task ID to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteId) && taskManager.DeleteTaskById(deleteId))
                        Console.WriteLine("Task deleted.");
                    else
                        Console.WriteLine("Invalid ID.");
                    break;

                case 6:
                    var upcoming = taskManager.GetUpcomingTasks();
                    if (upcoming.Count == 0)
                    {
                        Console.WriteLine("No tasks due in the next 2 days.");
                    }
                    else
                    {
                        foreach (var task in upcoming)
                        {
                            task.Display();
                        }
                    }
                    break;

                case 7:
                    Console.WriteLine("Exiting...");
                    break;
            }
        }
    }
}

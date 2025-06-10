using DotNetSeries.Models;
using DotNetSeries.Enums;

namespace DotNetSeries.Services
{
    public class TaskManager
    {
        private List<TaskItem> tasks = new();
        private int NextId = 1;

        private int GetNextId()
        {
            return NextId++;
        }

        public void AddTask(string name, string description, Priority priority, DateTime dueDate)
        {
            var task = new TaskItem(GetNextId(), name, description, priority, dueDate, Status.Pending);
            tasks.Add(task);
            Console.WriteLine($"Task '{task.Name}' added successfully.");
        }

        public List<TaskItem> GetAllTasks()
        {
            return tasks;
        }

        public List<TaskItem> SearchByStatus(Status status)
        {
            return tasks.Where(t => t.Status == status).ToList();
        }

        public List<TaskItem> SearchByPriority(Priority priority)
        {
            return tasks.Where(t => t.Priority == priority).ToList();
        }

        public bool MarkTaskAsCompleted(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.Status = Status.Completed;
                return true;
            }
            return false;
        }

        public bool DeleteTaskById(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
                return true;
            }
            return false;
        }

        public List<TaskItem> GetUpcomingTasks()
        {
            var today = DateTime.Now;
            return tasks
                .Where(t => t.DueDate >= today && t.DueDate <= today.AddDays(2))
                .OrderBy(t => t.DueDate)
                .ToList();
        }

        public bool ExistsTaskWithId(int id)
        {
            return tasks.Any(t => t.Id == id);
        }
    }
}

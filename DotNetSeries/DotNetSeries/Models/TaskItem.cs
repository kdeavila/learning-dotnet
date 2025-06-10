namespace DotNetSeries.Models;

using DotNetSeries.Enums;

public class TaskItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Priority Priority { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime DueDate { get; set; }
    public Status Status { get; set; }

    public TaskItem(int id, string name, string description, Priority priority, DateTime dueDate, Status status)
    {
        Id = id;
        Name = name;
        Description = description;
        Priority = priority;
        CreatedAt = DateTime.Now;
        DueDate = dueDate;
        Status = status;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Description: {Description}, Priority: {Priority}, Due Date: {DueDate.ToShortDateString()}, Status: {Status}");
    }
}

Console.WriteLine("Starting tasks...");

// Start multiple tasks
var task1 = DoTask("Waiting server A", 2000);
var task2 = DoTask("Waiting server B", 1000);
var task3 = DoTask("Waiting server C", 3000);
var task4 = DoTask("Waiting server D", 1500);

await Task.WhenAll(task1, task2, task3, task4);
Console.WriteLine("All tasks completed.");

await Task.WhenAny(task1, task2, task3, task4);
Console.WriteLine("At least one task completed.");
async Task DoTask(string name, int delay)
{
    Console.WriteLine($"Task {name} started.");
    await Task.Delay(delay);
    Console.WriteLine($"Task {name} completed after {delay}ms.");
}
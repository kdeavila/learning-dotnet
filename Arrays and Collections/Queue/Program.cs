var queue = new Queue<string>();

queue.Enqueue("First");
queue.Enqueue("Second");
queue.Enqueue("Third");

while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}
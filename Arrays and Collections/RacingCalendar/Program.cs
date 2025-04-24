var races = new Queue<Race>();

Race race1 = new Race("Race1", "24/01/2025", "Track1");
Race race2 = new Race("Race2", "25/12/2025", "Track2");
Race race3 = new Race("Race3", "26/01/2025", "Track3");
Race race4 = new Race("Race4", "27/04/2025", "Track4");
Race race5 = new Race("Race5", "28/11/2025", "Track5");

races.Enqueue(race1);
races.Enqueue(race2);
races.Enqueue(race3);
races.Enqueue(race4);
races.Enqueue(race5);

var orderedRaces = races.OrderBy(r => r.Date);

foreach (var race in orderedRaces)
{
    Console.WriteLine($"{race.Name} will be on {race.Date} in {race.NameTrack}");
    // Expected Output: Race1 will be on 24/04/2025 in Track1
}

race1.AddDriver("Emilio Pérez");
// Expected Output: Emilio Pérez has been added.

var waitingList = new WaitingList();

waitingList.AddDriver("Emilio Pérez");
waitingList.AddDriver("Juan Pérez");
waitingList.AddDriver("Carlos Pérez");
// Expected Output: Carlos Pérez added. Drivers waiting: 3

Driver lastDriver = waitingList.GetLastDriver();
Console.WriteLine($"Last driver: {lastDriver.Name}");
// Expected Output: Last driver: Carlos Pérez

public class WaitingList
{
    private Stack<Driver> waitingList = new Stack<Driver>();

    public void AddDriver(string name)
    {
        if (waitingList.Any(d => d.Name == name))
        {
            Console.WriteLine($"{name} is already in the waiting list.");
            return;
        }

        Driver newDriver = new Driver(name);
        waitingList.Push(newDriver);
        Console.WriteLine($"{newDriver.Name} added. Drivers waiting: {waitingList.Count}");
    }

    public Driver GetLastDriver()
    {
        if (waitingList.Count == 0)
        {
            throw new InvalidOperationException("Waiting list is empty.");
        }
        
        Driver lastDriver = waitingList.Pop();
        return lastDriver;
    }
}

public class Driver
{
    public Driver(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
}

public class Race
{
    private List<Driver> drivers = new List<Driver>();

    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string NameTrack { get; set; }

    public Race(string name, string date, string nameTrack)
    {
        Name = name;
        Date = DateTime.Parse(date);
        NameTrack = nameTrack;
    }

    public void AddDriver(string name)
    {
        if (drivers.Count < 20)
        {
            Driver newDriver = new Driver(name);
            drivers.Add(newDriver);
            Console.WriteLine($"{newDriver.Name} has been added.");
        } else
        {
            Console.WriteLine($"Race is full!");    
        }
    }
    
    public void GetDrivers()
    {
        foreach (var driver in drivers)
        {
            if (driver != null)
            {
                Console.WriteLine(driver.Name);
            }
        }
    }
}
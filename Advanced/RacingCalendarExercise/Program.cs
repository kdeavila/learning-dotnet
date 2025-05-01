public class Race
{
    public Race(string name, DateTime date, int raceAvailable)
    {
        Name = name;
        Date = date;
        RaceAvailable = raceAvailable;
    }

    public string Name { get; set; }
    public DateTime Date { get; set; }
    public int RaceAvailable { get; set; }
 }

public class Team
{
    public Team(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    private List<String> WaitingList = new List<String>();

    public void AddDriver(string name)
    {
        WaitingList.Add(name);
        Console.WriteLine($"Driver {name} added");
    }
}

public class Booking
{
    public Team Team { get; set; }
    public Race race { get; set; }
    public int CircuitsBooked { get; set; } = 0;
}
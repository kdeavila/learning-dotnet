House house1 = new House(1990, 100);
House house2 = new House(2010, 200);
Console.WriteLine($"House 1 can be sold: {house1.CanBeSold()}");
Console.WriteLine($"House 2 can be sold: {house2.CanBeSold()}");

class House
{
    public House(int year, int meters)
    { 
        Year = year;
        Meters = meters;
    }

    public int Year { get; set; }
    public int Meters { get; set; }

    private int HowOld()
    {
        DateTime dateNow = DateTime.Now;
        int actualYear = dateNow.Year;

        return actualYear - Year;
    }

    public bool CanBeSold()
    {
        int age = HowOld();

        return age >= 15;
    }
}
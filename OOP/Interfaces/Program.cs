ICar tesla = new TeslaModelS();
ICar ford = new FordMustang();

Console.WriteLine($"Car: {tesla.GetName()}, Top Speed: {tesla.GetTopSpeed()} mph");
Console.WriteLine($"Car: {ford.GetName()} , Top Speed:  {ford.GetTopSpeed()} mph");

public interface ICar
{
    string GetName();
    int GetTopSpeed();
}

public class TeslaModelS : ICar
{
    public string GetName()
    {
        return "Tesla Model S";
    }

    public int GetTopSpeed()
    {
        return 200;
    }
}


public class FordMustang : ICar
{
    public string GetName()
    {
        return "Ford Mustang";
    }
    public int GetTopSpeed()
    {
        return 150;
    }
}
using Humanizer;

Console.WriteLine("- Quantities");
HumanizeQuantities();

Console.WriteLine("\n- Date/Time Manipulation");
HumanizeDates();

static void HumanizeQuantities()
{
    Console.WriteLine("animal".ToQuantity(0));
    Console.WriteLine("house".ToQuantity(1));
    Console.WriteLine("car".ToQuantity(2));
}

static void HumanizeDates()
{
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}
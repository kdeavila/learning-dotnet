using System.Globalization;

DateTime dateOfBirth = new DateTime(2005, 12, 03);
Console.WriteLine(dateOfBirth.DayOfWeek);

// Computed values
DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
DateTime utcNow = DateTime.UtcNow;

Console.WriteLine(today);
Console.WriteLine(now);
Console.WriteLine(utcNow);

// DateTime parsing

DateTime localDate = DateTime.Parse("03.12.2005");
DateTime usDate = DateTime.Parse("12/03/2005", new CultureInfo("es-US"));

Console.WriteLine($"Localdate: {localDate}, usDate: {usDate}");

// DateTime formatting

Console.WriteLine(dateOfBirth.ToString());
Console.WriteLine(dateOfBirth.ToString(new CultureInfo("es-US")));
Console.WriteLine(dateOfBirth.ToString("yyyy-MM-dd"));
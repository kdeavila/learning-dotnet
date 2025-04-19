using System.Globalization;

string luckyNumber = "16";

// Convert to int

int paseLuckyNumber = int.Parse(luckyNumber);
Console.WriteLine($"Lucky number: {paseLuckyNumber}");

// Culture info
CultureInfo cultureInfo = new CultureInfo("de-DE");

double temperature = double.Parse("30.7", cultureInfo);
double temperature2 = double.Parse("30.,7", cultureInfo);

Console.WriteLine($"Temp: {temperature}");
Console.WriteLine($"Temp2: {temperature2}");
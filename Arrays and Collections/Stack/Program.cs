var countries = new Stack<string>();

countries.Push("USA");
countries.Push("Canada");
countries.Push("Mexico");
countries.Push("Brazil");
countries.Push("Argentina");

var lastCountry = countries.Pop();
Console.WriteLine($"Last country added: {lastCountry}");

var topCountry = countries.Peek();
Console.WriteLine($"Top country in the stack: {topCountry}\n");

foreach (var country in countries)
{
    Console.WriteLine($"Country in stack: {country}");
}
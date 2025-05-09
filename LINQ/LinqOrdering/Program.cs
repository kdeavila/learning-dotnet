using System;
using System.Linq;

var products = new[]
{
    new { Name = "T shirt", Price = 25.0m, Rating = 4 },
    new { Name = "Jeans", Price = 50.0m, Rating = 5 },
    new { Name = "Sneakers", Price = 75.0m, Rating = 3 },
    new { Name = "Hat", Price = 15.0m, Rating = 4 },
    new { Name = "Jacket", Price = 100.0m, Rating = 5 },
    new { Name = "Socks", Price = 5.0m, Rating = 2 },
    new { Name = "Belt", Price = 20.0m, Rating = 4 },
};

// Order by price desc
var byPriceAsc = products.OrderBy(p => p.Price);

// Order by price desc
var byPriceDesc = products.OrderByDescending(p => p.Price);

// Order by rating desc and then by name asc
var byRatingThenName = products.OrderByDescending(p => p.Rating).ThenBy(p => p.Name);

Console.WriteLine("-> Asc price");
foreach (var p in byPriceAsc) Console.WriteLine($"    {p.Name}: ${p.Price}");

Console.WriteLine("\n-> Desc price");
foreach (var p in byPriceDesc) Console.WriteLine($"    {p.Name}: ${p.Price}");

Console.WriteLine("\n-> Desc rating then asc name");
foreach (var p in byRatingThenName) Console.WriteLine($"    {p.Name}: ${p.Price} - {p.Rating} stars");


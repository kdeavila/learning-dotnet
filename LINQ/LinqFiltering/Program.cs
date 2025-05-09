using System;
using System.Linq;

var products = new[]
{
    new {Name = "T shirt ", Price = 19.99, InStock = true },
    new {Name = "Jeans", Price = 49.99, InStock = true },
    new {Name = "Sneakers", Price = 89.99, InStock = true },
    new {Name = "Hat", Price = 15.99, InStock = false }, 
    new {Name = "Socks", Price = 5.99, InStock = false },
};


// Filter products by availability
var availables = products.Where(p => p.InStock);

// Filter products by price
var expensives = availables.Where(p => p.Price > 70);

Console.WriteLine("Products in stock and price > 70");
foreach (var p in expensives)
{
    Console.WriteLine($"{p.Name} - ${p.Price}");
}

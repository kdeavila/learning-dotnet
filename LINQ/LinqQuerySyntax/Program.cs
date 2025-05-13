using System;
using System.Linq;

var products = new[]
{
    new { Name = "Camisa", Price = 25.0m },
    new { Name = "Pantalón", Price = 45.5m },
    new { Name = "Zapatos", Price = 60.0m },
    new { Name = "Sombrero", Price = 15.0m },
    new { Name = "Calcetines", Price = 5.0m }
};

var método = products
    .Where(p => p.Price > 20)
    .OrderBy(p => p.Price)
    .Select(p => new { p.Name, p.Price });

var query =
    from p in products
    where p.Price > 20
    orderby p.Price ascending
    select new
    {
        Nombre = p.Name,
        Precio = p.Price
    };

Console.WriteLine("— Método encadenado:");
foreach (var p in método)
    Console.WriteLine($"• {p.Name}: ${p.Price}");

Console.WriteLine("\n— Query Syntax:");
foreach (var p in query)
    Console.WriteLine($"• {p.Nombre}: ${p.Precio}");

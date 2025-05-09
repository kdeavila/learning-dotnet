using System;
using System.Linq;

var products = new[]
{
    new { Name = "T shirt", Price = 10.05m, InStock = true },
    new { Name = "Jeans", Price = 20.99m, InStock = false },
    new { Name = "Sneakers", Price = 50.00m, InStock = true },
    new { Name = "Hat", Price = 15.00m, InStock = true },
    new { Name = "Socks", Price = 5.00m, InStock = false }
};

var names = products.Select(p => p.Name);

var summary = products.Select(p => new
{
    p.Name,
    PriceWithTax = p.Price * 1.21m,
});

var dtoList = products.Select(p => new ProductDto
{
    Name = p.Name,
    PriceWithIVA = p.Price * 1.21m,
});

Console.WriteLine("-> Name List");
foreach (var name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("\n-> Summary With IVA");
foreach (var item in summary)
{
    Console.WriteLine($"{item.Name} - {item.PriceWithTax}");
}

Console.WriteLine("\n-> DTO List");
foreach (var item in dtoList)
{
    Console.WriteLine($"{item.Name} - {item.PriceWithIVA}");
}

public class ProductDto
{
    public string Name { get; set; }
    public decimal PriceWithIVA { get; set; }
}
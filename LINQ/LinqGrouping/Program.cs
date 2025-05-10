var fruits = new List<Product>
{
    new Product { Name = "Apple", Category = "Fruit" },
    new Product { Name = "Banana", Category = "Fruit" },
    new Product { Name = "Carrot", Category = "Vegetable" },
    new Product { Name = "Broccoli", Category = "Vegetable" },
    new Product { Name = "Potato", Category = "Vegetable" },
    new Product { Name = "Milk", Category = "Dairy" },
    new Product { Name = "Cheese", Category = "Dairy" },
};

var groupedProducts = fruits.GroupBy(p => p.Category);

foreach (var category in groupedProducts)
{
    Console.WriteLine($"\n{category.Key}:");

    foreach (var p in category)
    {
        Console.WriteLine($" - {p.Name}");
    }
}

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
}
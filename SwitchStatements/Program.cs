Console.WriteLine("Enter your age: ");
string? inputAge = Console.ReadLine();

int age = int.Parse(inputAge);

switch (age)
{
    case < 10:
        Console.WriteLine("You are a child.");
        break;
    case < 20:
        Console.WriteLine("You are a teenager.");
        break;
    case < 30:
        Console.WriteLine("You are a young adult");
        break;
    case < 40:
        Console.WriteLine("You are an adult.");
        break;
    case < 50:  
        Console.WriteLine("You are middle-aged.");
        break;
    default: 
        Console.WriteLine("Invalid age.");
        break;
}
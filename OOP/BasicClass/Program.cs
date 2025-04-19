// Instance a class

Person person1 = new Person("Keyner");
Person person2 = new Person("Brayan");

Console.WriteLine(person1.Name);
Console.WriteLine(person2.Name);

// Change the name of the first person

person1.Name = "Keyner de Ávila";
Console.WriteLine(person2.Name);

person1.PrintGreeting();
person2.PrintGreeting();

// Call the method GetGreeting

Console.WriteLine(person1.GetGreeting());
Console.WriteLine(person2.GetGreeting());

// Call the method Sum from the Math class

Math math = new Math();
int result = math.Sum(14, 16);
Console.WriteLine(result);

//class Person
//{
//    private string _name;

//    public Person()
//    {
//        _name = "Keyner";
//    }

//    public string Name
//    {
//        get { return _name; }
//        set { _name = value; }
//    }

//}


// 
class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public void PrintGreeting()
    {
        Console.WriteLine($"Hello, {Name}");
    }

    public string GetGreeting()
    {
        return $"Hello, {Name}";
    }
}

public class Math
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}
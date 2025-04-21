// Reference types

var person = new Person("John");
Console.WriteLine($"Name before method call: {person.Name}");

MethodParameters.ChangeName(person);
Console.WriteLine($"Name after method call: {person.Name}");

//var rectangle = new Rectangle(200, 300);

//Console.WriteLine($"Height before method call: {rectangle.Height}");

//MethodParameters.ChangeHeight(ref rectangle);
//Console.WriteLine($"Height after method call: {rectangle.Height}");

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}

public struct Rectangle
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; set; }
    public double Height { get; set; }
}

public class MethodParameters
{
    public static void ChangeName(Person person)
    {
        person.Name = "Keyner";

        // if we put ref here, it will mutate the reference
        // creating a new object and printing it
        person = new Person("New Name");
    }

    public static void ChangeHeight(ref Rectangle rectangle)
    {
        rectangle.Height = 500;
        Console.WriteLine($"Height inside method: {rectangle.Height}");
    }
}
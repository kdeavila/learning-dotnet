var name = "John Doe";
var age = 30;

var person = new Person(name, age);

Console.WriteLine($"Person Name: {person.Name}, Age: {person.Age}");

public class Person
{
    public string Name { get; set; } = "Default Name";
    public int Age { get; set; } = 25;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
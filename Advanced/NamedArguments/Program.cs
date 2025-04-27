var person1 = new Person("Keyner", 19, 3);
var person2 = new Person(name: "Keyner", age: 19, luckyNumber: 3);
var person3 = new Person("Keyner", luckyNumber: 3, age: 19);

Console.WriteLine($"{person1.Name}. Age: {person1.Age} years old. Lucky number: {person1.LuckyNumber}");
Console.WriteLine($"{person2.Name}. Age: {person2.Age} years old. Lucky number: {person2.LuckyNumber}");
Console.WriteLine($"{person3.Name}. Age: {person3.Age} years old. Lucky number: {person3.LuckyNumber}");

public class Person
{
    public Person(string name, int age, int luckyNumber)
    {
        Name = name;
        Age = age;
        LuckyNumber = luckyNumber;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public int LuckyNumber { get; set; }
}
var person1 = new Person("Keyner", 19);
Console.WriteLine(person1.LuckyNumber);

var person2 = new Person("Keyner", age: 19, luckyNumber: 3);
Console.WriteLine(person2.LuckyNumber);

public class Person
{
    // Optional arguments must be at the end of the parameter list
    public Person(string name, int age, string favoriteColor, int luckyNumber = 7)
    {
        Name = name;
        Age = age;
        FavoriteColor = favoriteColor;
        LuckyNumber = luckyNumber;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public int LuckyNumber { get; set; }
    public string FavoriteColor { get; set; }
}
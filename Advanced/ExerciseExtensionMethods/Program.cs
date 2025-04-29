using ExerciseExtensionMethods.Extensions;

Person person = new Person(name: "Keyner", age: 19, hasCarnet: true);
Console.WriteLine($"Is {person.Name} an adult? {person.IsAdult()}");

Console.WriteLine($"Does {person.Name} have an ID and a carnet? {person.HasIdAndCarnet()}");
person.HasCarnet = false;

Console.WriteLine($"Does {person.Name} have an ID and a carnet? {person.HasIdAndCarnet()}");

public interface IStudent
{
    string Id { get; }
    bool HasCarnet { get; set; }
}

public class Person : IStudent
{
    public Person(string name, int age, bool hasCarnet = false, string favoriteColor = "Blue", int luckyNumber = 0)
    {
        Name = name;
        Age = age;
        FavoriteColor = favoriteColor;
        LuckyNumber = luckyNumber;
        HasCarnet = hasCarnet;
    }
    public string Id { get { return "Ea18JanHKjm129a"; } }
    public bool HasCarnet { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int LuckyNumber { get; set; }
    public string FavoriteColor { get; set; }
}
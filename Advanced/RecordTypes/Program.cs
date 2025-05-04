var person1 = new Person("Keyner", 19);
var person2 = new Person("Keyner", 19);

Console.WriteLine(person1);
Console.WriteLine(person1 == person2
    ? "They're equal"
    : "They're not equal"
    );

var person3 = person1 with { Age = 20 };
Console.WriteLine(person3);

public record Person(string Name, int Age);
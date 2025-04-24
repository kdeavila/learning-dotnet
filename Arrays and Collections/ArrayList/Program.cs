using System.Collections;

var arrayList = new ArrayList();

var day = 22;
arrayList.Add(day);

var person1 = new Person("Keyner");
arrayList.Add(person1);

var firstElement = arrayList[0];
Console.WriteLine($"First element: {firstElement}"); // Output: 22

foreach (var item in arrayList)
{
    if (item is Person)
    {
        var Person = item as Person;
        if (Person != null)
        {
            Console.WriteLine($"Person: {Person.Name}");
        }
    } else
    {
        Console.WriteLine($"Item: {item}");
    }
}
        
public class Person
{
    public string Name { set; get; }

    public Person(string name)
    {
        Name = name;
    }
}
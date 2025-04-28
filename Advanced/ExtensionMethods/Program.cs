using ExtensionMethods.Extensions;

var person = new Person("Keyner", "de Ávila");
Console.WriteLine(person.ToFullName());
Console.WriteLine(person.HasId());

public interface IIdentification
{
    int Id { get; }
}

public static class IdentificationExtensions
{
    public static bool HasId(this IIdentification identificaction)
    {
        return identificaction.Id > 0;
    }
}

public class Person : IIdentification
{
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Id { get { return 7; } }
}
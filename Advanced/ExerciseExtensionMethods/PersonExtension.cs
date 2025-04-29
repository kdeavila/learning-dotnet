namespace ExerciseExtensionMethods.Extensions;

public static class PersonExtension
{
    public static bool IsAdult(this Person person)
    {
        return person.Age >= 18;
    }
}
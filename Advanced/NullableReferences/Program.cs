// Activate <Nullable> in the project file
// <Nullable>enable</Nullable>

string greetings = "Hola, Keyner";
greetings = null;

//Console.WriteLine(greetings.Length); // Warning: Dereference of a possibly null reference

string? userName = GetUser();

if (userName != null)
{
    Console.WriteLine($"User: {userName.Length} characters");
}
else
{
    Console.WriteLine("User name is null");
}

int size = userName!.Length;
Console.WriteLine(size);

static string? GetUser()
{
    return null;
}

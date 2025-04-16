// String type

string helloWorld = "Hello world!";
Console.WriteLine(helloWorld);

// Empty string

string emptyString = string.Empty;
Console.WriteLine(emptyString);

// Double quote

string doubleQuote = "He said, \"Hello world!\"";
Console.WriteLine(doubleQuote);

string filePath = "C:\\temp";
Console.WriteLine(filePath);

string filePath2 = @"C:\temp";
Console.WriteLine(filePath2);

// String length

string stringLength = "Hello world!";
Console.WriteLine(stringLength.Length);

// String concatenation

string firstName = "John";
string lastName = "Doe";
string fullName = firstName + " " + lastName;

Console.WriteLine(fullName);

// String interpolation

string name = "John";
int age = 30;
string greeting = $"Hello, my name is {name} and I am {age} years old.";
Console.WriteLine(greeting);
Console.WriteLine($"The result is: {5 * 4}");

// Substring

string substring = "Hello world!";
string sub = substring.Substring(0, 5);
Console.WriteLine(sub);
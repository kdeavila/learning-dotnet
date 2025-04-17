// If statements

int luckyNumber = 3;

if (luckyNumber == 3)
{
    Console.WriteLine("Lucky number is 3");
}
else if (luckyNumber == 7)
{
    Console.WriteLine("Lucky number is 7");
}
else
{
    Console.WriteLine("Lucky number is not 3 or 7");
}

string name = "Keyner";

if (name == "Keyner")
{
    Console.WriteLine("Hello Keyner");
}
else if (name == "John")
{
    Console.WriteLine("Hello John");
}
else
{
    Console.WriteLine("Hello, nice to meet you");
}

// Ternary Operator

int version = 4;
string productVersion = version == 4 ? "4.0" : "5.0";
Console.WriteLine($"Product version: {productVersion}");
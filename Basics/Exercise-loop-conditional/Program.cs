// Define a loop that defines a variable with the value 0 and stops at 20. Increase the value of the variable at every iteration. Decide what loop fits this problem best. Print a message to the console, including the variable's value for every iteration.

for (int a = 0; a < 20; a++)
{
    Console.WriteLine($"a: {a}");
}


// Extend the previously created solution by only printing a message for values higher than 10. Decide what building block suits this problem best.

Console.WriteLine();
Console.WriteLine("Printing values higher than 10");

for (int a = 0; a < 20; a++)
{
    if (a > 10)
    {
        Console.WriteLine($"a: {a}");
    }
}

// Write a program that prints a happy birthday based on user input. Ask the user for his age and reply on the console with a happy birthday message mentioning the user input.

Console.WriteLine();
Console.WriteLine("Enter your age: ");

string? inputAge = Console.ReadLine();
int age = int.Parse(inputAge);

Console.WriteLine($"Happy birthday! You are now {age} years old.");

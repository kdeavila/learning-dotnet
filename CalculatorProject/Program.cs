// The following features should be implemented:

// Ask the user for two numbers and a calculation method.
// Valid calculation methods are addition, subtraction, multiplication, and division.
// After the user has input their information, calculate the result and print it on the console.
// After the result has been printed, ask the user for another calculation. The program shouldd only end if the user decides that he does not want to calculate another result.

Console.WriteLine("Welcome to the Console Calculator");

int menuOption = 1;

while (menuOption != 0)
{
    Console.WriteLine("Please select an option: \n");

    Console.WriteLine("Enter a number: ");
    string? inputNumber1 = Console.ReadLine();

    Console.WriteLine("Enter another number: ");
    string? inputNumber2 = Console.ReadLine();

    int number1 = int.Parse(inputNumber1);
    int number2 = int.Parse(inputNumber2);

    Console.WriteLine("\n1. Add\n2. Subtract\n3. Multiply\n4. Divide\n5. Modulus\n");

    Console.WriteLine("Enter your option: ");
    string? inputMenuOption = Console.ReadLine();

    int option = int.Parse(inputMenuOption);

    switch (option)
    {
        case 1:
            Console.WriteLine($"The result of {number1} + {number2} = {number1 + number2}");
            break;
        case 2:
            Console.WriteLine($"The result of {number1} - {number2} = {number1 - number2}");
            break;
        case 3:
            Console.WriteLine($"The result of {number1} * {number2} = {number1 * number2}");
            break;
        case 4:
            if (number2 != 0)
            {
                Console.WriteLine($"The result of {number1} / {number2} = {number1 / number2}");
            } else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
                break;
        case 5:
            Console.WriteLine($"The result of {number1} % {number2} = {number1 % number2}");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

    Console.WriteLine("\nDo you want to calculate another result? (1. yes / 2. no)");
    string? inputCalculateAgain = Console.ReadLine();

    int calculateAgain = int.Parse(inputCalculateAgain);

    menuOption = calculateAgain == 1 ? 1 : 0;
}
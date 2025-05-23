int result = Fibonacci(5);
Console.WriteLine(result);

static int Fibonacci(int number) 
{
    int number1 = 0;
    int number2 = 1;
    int sum;

    if (number == 0) return number1;
    if (number == 1) return number2;

    for (int i = 2; i <= number; i++)
    {
        sum = number1 + number2;
        number1 = number2;
        number2 = sum;
    }

    return number2;
}
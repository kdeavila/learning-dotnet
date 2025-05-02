var result1 = SumAll(1, 2, 3, 4, 5);
var result2 = SumAll(1, 2, 3);
var result3 = SumAll(2, 4, 6, 8, 10);

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);

static int SumAll(params int[] values)
{
    var total = 0;
    foreach (var v in values)
    {
        total += v;
    }

    return total;
}
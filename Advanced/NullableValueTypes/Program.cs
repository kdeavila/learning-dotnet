int? possibleValue = GetScore(42);

Console.WriteLine(
    possibleValue.HasValue
    ? $"Value found: {possibleValue.Value}"
    : "No value found"
);

DateTime? inputDate = ParseDate(null);
Console.WriteLine(
    inputDate.HasValue
    ? $"Parsed date: {inputDate.Value}"
    : "Invalid date format"
);


static int? GetScore(int? userId)
{
    if (userId == 42) return null;
    return 100;
}

static DateTime? ParseDate(string? text)
{
    if (DateTime.TryParse(text, out var d))
    {
        return d;
    }

    return null;
}
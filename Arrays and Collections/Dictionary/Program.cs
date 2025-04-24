var grades = new Dictionary<int, string>
{
    { 6, "F" }
};

grades.Add(5, "E");
grades[4] = "D";
grades[3] = "C";
grades[2] = "B";
grades[1] = "A";

Console.WriteLine(grades[1]);

foreach (var grade in grades)
{
    Console.WriteLine($"Key: {grade.Key}, Value: {grade.Value}");
}

Console.WriteLine(grades.ContainsKey(7));

//grades.Remove(2);

grades.TryGetValue(2, out var value);
Console.WriteLine(value);

grades.TryAdd(1, "A+");
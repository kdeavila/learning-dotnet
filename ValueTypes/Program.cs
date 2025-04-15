// Boolean - bool
bool enabled = false;
Console.WriteLine($"Bool: {enabled}");

enabled = true;
Console.WriteLine($"Bool: {enabled}");

char c1 = 'a';
Console.WriteLine($"Char: {c1}");

// Intergers - int
int a = 0;
int b = 1;
int c = 2;

Console.WriteLine($"a: {a}, b: {b}, c: {c}");

// Aritmetics operations
int multiply = b * c;
int divide = c / b;
int add = a + b;
int subtract = a - b;

Console.WriteLine($"Multiply: {multiply}, divide: {divide}, add: {add}, subtract: {subtract}");

// Long
long i = 99;
Console.WriteLine($"Long: {i}");

// Floating point numbers
float f = 3.5f;
double g = 7.8d;
decimal dec = 7.15m;

Console.WriteLine($"f: {f}, g: {g}, dec: {dec}");

Console.WriteLine($"Float calc: {0.1111111f / 0.8324234f}");
Console.WriteLine($"Double calc: {0.1111111d / 0.8324234d}");
Console.WriteLine($"Decimal calc: {0.1111111m / 0.8324234m}");

// Copying values

int a1 = 7;
int a2 = a1;
a1 = 5;

Console.WriteLine($"a1: {a1}, a2: {a2}");

// Nullable value types
int? n1 = null;
bool? n2 = null;

Console.WriteLine($"n1: {n1}, n2: {n2}");

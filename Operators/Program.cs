// Decrement and Increment Operators

int a = 7;
int b = a++;
Console.WriteLine($"a: {a}, b: {b}");

int c = 7;
int d = --c;
Console.WriteLine($"c: {c}, d: {d}");

// Arithmetic Operators
Console.WriteLine();

int e = 2 + 7;
int f = 9 - 3;
int g = 10 * 4;
int h = 20 / 5;

Console.WriteLine($"e: {e}, f: {f}, g: {g}, h: {h}");

// Comparison Operators
Console.WriteLine();

int k = 5;
int l = 10;

Console.WriteLine(k > l);
Console.WriteLine(k < l);
Console.WriteLine(k <= l);
Console.WriteLine(k >= l);

// Boolean Logical Operators
Console.WriteLine();

bool isRegistered = true;

Console.WriteLine($"isRegistered: {isRegistered}");
Console.WriteLine($"isRegistered NOT: {!isRegistered}");

bool isMonday = false;
bool isWeekend = true;

Console.WriteLine($"isMonday AND isWeekend: {isMonday && isWeekend}");
Console.WriteLine($"isMonday OR isWeekend: {isMonday || isWeekend}");

// Equals Operator 
Console.WriteLine();

string myName = "Keyner";
string myCountry = "Colombia";
int myBirthDay = 03;

Console.WriteLine($"myBirthDay is NOT 16: {myBirthDay != 16}");
Console.WriteLine($"myBirthDay == 16: {myBirthDay == 16}");
Console.WriteLine($"myName == myCountry: {myName == myCountry}");
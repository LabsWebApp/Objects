// Action

// ReSharper disable All
DoOperation(10, 6, Add);        // 10 + 6 = 16
DoOperation(10, 6, Multiply);   // 10 * 6 = 60

void DoOperation(int a, int b, Action<int, int> op) => op(a, b);

void Add(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = {x * y}");

Console.WriteLine("*****");

// Predicate

Predicate<int> isPositive = (int x) => x > 0;

Console.WriteLine(isPositive(20));
Console.WriteLine(isPositive(-20));

Console.WriteLine("*****");

// Func

int result1 = DoFunc(6, DoubleNumber); // 12
Console.WriteLine(result1);

int result2 = DoFunc(6, SquareNumber); // 36
Console.WriteLine(result2);

int DoFunc(int n, Func<int, int> operation) => operation(n);
int DoubleNumber(int n) => 2 * n;
int SquareNumber(int n) => n * n;

Console.WriteLine("*****");

Func<int, int, string> createString = (a, b) => $"{a}{b}";
Console.WriteLine(createString(1, 5));  // 15
Console.WriteLine(createString(3, 5));  // 35

Console.ReadKey();
// Анонимные (лямбда) методы.


Delegate simpleDelegate = delegate(int a, double b)
{
    return a + b;
};

var x = delegate(int a, double b) { return a + b; };

Console.WriteLine(simpleDelegate.GetType().FullName);
Console.WriteLine(simpleDelegate(1, 2).GetType().FullName);
Console.WriteLine(x.GetType().FullName);

Console.WriteLine(simpleDelegate(1, 2));

Console.ReadKey();

simpleDelegate = (a, b) =>
{
    return a + b;
};

simpleDelegate -= (a, b) =>
{
    return a + b;
};


var summand1 = 1;
double summand2 = 2.5;
double sum = 0;

sum = simpleDelegate?.Invoke(summand1, summand2) ?? double.NaN;

Console.WriteLine($"{summand1} + {summand2} = {sum}");

// Delay.
Console.ReadKey();


// Создаем класс делегата.
internal delegate double Delegate(int a, double b);
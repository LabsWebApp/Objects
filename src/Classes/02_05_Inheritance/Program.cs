using Inheritance;

DerivedClass instance = new DerivedClass(1, 2);

Console.WriteLine(instance.BaseNumber);
Console.WriteLine(instance.DerivedField);

DerivedClass instance2 = new();
Console.WriteLine(instance2.BaseNumber);

// Delay.
Console.ReadKey();
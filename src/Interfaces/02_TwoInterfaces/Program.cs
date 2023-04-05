using TwoInterfaces;

IInterface1 instance1 = new DerivedClass();
IInterface2 instance2 = new DerivedClass();

instance1.Method1();
//instance1.Method2();
(instance1 as IInterface2)?.Method2();

instance2.Method2();
// instance2.Method1();

Console.WriteLine(instance1.GetType().BaseType);
Console.WriteLine(instance2.GetType().BaseType);

// Delay.
Console.ReadKey();
using TwoInterfaces;

IInterface1 instance1 = new DerivedClass();
IInterface2 instance2 = new DerivedClass();

instance1.Method1();
// instance1.Method2();
// (instance1 as IInterface2)?.Method2();

instance2.Method2();
// instance2.Method1();

// Delay.
Console.ReadKey();
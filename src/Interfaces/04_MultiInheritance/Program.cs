using MultiInheritance;

DerivedClass instance = new DerivedClass();
instance.Method();
instance.Method1();
instance.Method2();

Console.WriteLine(new string('-', 40));

BaseClass instance0 = instance as BaseClass;
instance0.Method();

IInterface1 instance1 = instance as IInterface1;
instance1.Method1();

IInterface2 instance2 = instance as IInterface2;
instance2.Method2();

// Delay.
Console.ReadKey();
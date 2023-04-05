using ExplicitImplementation;

DerivedClass instance = new DerivedClass();

//instance.  // На экземпляре не видим методов интерфейсов.

// Приведем экземпляр класса DerivedClass - instance, к базовому интерфейсному типу Interface1

(instance as IInterface1).Method();

IInterface1 instance1 = instance as IInterface1;
instance1.Method();

IInterface2 instance2 = instance as IInterface2;
instance2.Method();

// Delay.
Console.ReadKey();
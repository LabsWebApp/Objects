using VirtualAndAbstract;

ConcreteDerivedClass instance = new ConcreteDerivedClass();

instance.SimpleMethod();
instance.VirtualMethod();
instance.AbstractMethod();

//Delay.
Console.ReadKey();
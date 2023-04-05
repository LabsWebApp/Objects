using VirtualAndAbstract;

ConcreteDerivedClass instance = new ConcreteDerivedClass { Name = "Вася" };

instance.SimpleMethod();
instance.VirtualMethod();
instance.AbstractMethod();

Console.WriteLine(instance.Name);

//Delay.
Console.ReadKey();
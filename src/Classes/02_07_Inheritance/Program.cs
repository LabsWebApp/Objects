
DerivedClass instance = new DerivedClass();
instance.Method();

// UpCast
BaseClass instanceUp = instance;
instanceUp.Method();

// DownCast
DerivedClass instanceDown = (DerivedClass)instanceUp;
instanceDown.Method();

// Проверка.
Console.WriteLine($"instance Id     {instance.GetHashCode()}");
Console.WriteLine($"instanceUp Id   {instanceUp.GetHashCode()}");
Console.WriteLine($"instanceDown Id {instanceDown.GetHashCode()}");

// Delay.
Console.ReadKey();


internal class BaseClass
{
    public void Method() => Console.WriteLine("Method from BaseClass");
}

internal class DerivedClass : BaseClass
{
    // Замещение метода базового класса.

    public void Method() => Console.WriteLine("Method from DerivedClass");
}
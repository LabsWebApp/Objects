// Cast с использованием оператора as.
DerivedClass instance = new DerivedClass();
instance.Method();

// UpCast
BaseClass instanceUp = instance as BaseClass;
instanceUp.Method();


// DownCast
DerivedClass? instanceDown = instanceUp as DerivedClass;
instanceDown?.Method();

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
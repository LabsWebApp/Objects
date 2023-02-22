DerivedClass instance = new DerivedClass();
instance.Method();

// UpCast
BaseClass instanceUp = instance;
instanceUp.Method();

// DownCast
DerivedClass instanceDown = (DerivedClass)instanceUp;
instanceDown.Method();

// Delay.
Console.ReadKey();

internal class BaseClass
{
    public virtual void Method() => Console.WriteLine("Method from BaseClass");
}

internal class DerivedClass : BaseClass
{
    // Переопределение метода базового класса.
    public override void Method()
    {
        // Вызов метода базового класса.
        base.Method();
        Console.WriteLine("Method from DerivedClass");
    }
}
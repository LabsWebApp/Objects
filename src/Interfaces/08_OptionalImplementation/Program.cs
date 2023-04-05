// Наследование от класса и интерфейса у которых совпадают сигнатуры членов.

DerivedClass instance = new DerivedClass();
instance.Method();

BaseClass instance1 = instance as BaseClass;
instance1.Method();

IInterface instance2 = instance as IInterface;
instance2.Method();

// Delay.
Console.ReadKey();

internal interface IInterface
{
    void Method();
}

internal class BaseClass
{
    public virtual void Method() => Console.WriteLine("BaseClass.Method()");
}

internal class DerivedClass : BaseClass, IInterface
{
    // Реализация интерфейса не обязательна, т.к., 
    // сигнатуры методов в классе и интерфейсе совпадают.
    //public override void Method() => Console.WriteLine("DerivedClass.Method()");
}
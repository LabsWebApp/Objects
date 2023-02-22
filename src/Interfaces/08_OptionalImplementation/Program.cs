// Наследование от класса и интерфейса у которых совпадают сигнатуры членов.

DerivedClass instance = new DerivedClass();
instance.Method();

IInterface instance1 = instance as IInterface;
instance1.Method();

// Delay.
Console.ReadKey();

interface IInterface
{
    void Method() => Console.WriteLine("Реализация по умолчанию");
}

class BaseClass
{
    public void Method() => Console.WriteLine("BaseClass.Method()");
}

class DerivedClass : BaseClass, IInterface
{
    // Реализация интерфейса не обязательна, т.к., 
    // сигнатуры методов в классе и интерфейсе совпадают.
}
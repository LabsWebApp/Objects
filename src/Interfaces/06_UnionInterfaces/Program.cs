// Наследование от интерфейсов у которых совпадают имена членов.

ConcreteClass instance = new ConcreteClass();
instance.Method();

IInterface1 instance1 = instance as IInterface1;
instance1.Method();

IInterface2 instance2 = instance as IInterface2;
instance2.Method();

// Delay.
Console.ReadKey();

// Объединение реализации одноименных абстрактных членов.

internal interface IInterface1
{
    void Method();
}

internal interface IInterface2
{
    void Method();
}

internal class ConcreteClass : IInterface1, IInterface2
{
    public void Method() => Console.WriteLine("Method - реализация интерфейса IInterface (1-2)");
}

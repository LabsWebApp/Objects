// Наследование абстрактных классов от интерфейсов.

ConcreteClass instance = new ConcreteClass();
instance.Method1();
instance.Method2();
(instance as IInterface).Method2();

// Delay.
Console.ReadKey();

internal interface IInterface
{
    void Method1();
    void Method2();
}

internal abstract class AbstractClass : IInterface
{
    // Реализация абстрактного метода из интерфейса, в абстрактном классе обязательна.
    public void Method1() => Console.WriteLine("Метод - реализация интерфейса в абстрактном классе.");
    
    // Замещение абстрактного метода из интерфейса, в абстрактном классе обязательно.
    public abstract void Method2();
}

internal class ConcreteClass : AbstractClass
{
    public override void Method2() => Console.WriteLine("Метод - реализация интерфейса в абстрактном классе.");
}
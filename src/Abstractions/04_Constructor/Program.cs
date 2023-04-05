AbstractClass instance = new ConcreteClass();

Console.WriteLine(new string('-', 55));

instance.AbstractMethod();

// Задержка.
Console.ReadKey();


internal abstract class AbstractClass
{
    // Конструктор (отрабатывает первым).
    public AbstractClass()  //protected AbstractClass()
    {
        Console.WriteLine("1 AbstractClass()");

        // Вызывается реализация метода из производного класса
        this.AbstractMethod();

        Console.WriteLine("END AbstractClass()");
    }

    public abstract void AbstractMethod();
}

internal class ConcreteClass : AbstractClass
{
    private string s = "FIRST";

    // Конструктор (отрабатывает вторым).
    public ConcreteClass()
    {
        s = "SECOND";
        Console.WriteLine("3 ConcreteClass()");
    }

    public override void AbstractMethod() => Console.WriteLine($"Реализация метода AbstractMethod() в ConcreteClass  ({s})");
}
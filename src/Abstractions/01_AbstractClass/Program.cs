AbstractClass instance = new ConcreteClass();

instance.Method();

// Delay.
Console.ReadKey();


// Абстрактный класс.
internal abstract class AbstractClass
{
    // Абстрактный метод.
    public abstract void Method();
}

// Конкретный класс.
internal class ConcreteClass : AbstractClass
{
    // Конкретный метод.
    public override void Method() => Console.WriteLine("Implementation");
}
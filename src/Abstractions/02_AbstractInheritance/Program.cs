// Абстрактный класс может быть унаследован от конкретного класса.

AbstractClass instance = new ConcreteClassB();

instance.Method();
instance.Operation();

// Delay.
Console.ReadKey();

// Конкретный класс A.
internal class ConcreteClassA
{
    public void Operation() => Console.WriteLine("ConcreteClassA.Operation");
}

// Абстрактный класс.
internal abstract class AbstractClass : ConcreteClassA
{
    public abstract void Method();
}

// Конкретный класс B.
internal class ConcreteClassB : AbstractClass
{
    public override void Method() => Console.WriteLine("ConcreteClassB.Method");
}
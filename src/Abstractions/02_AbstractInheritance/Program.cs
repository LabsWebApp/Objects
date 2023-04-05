// Абстрактный класс может быть унаследован от конкретного класса.

using System.Threading.Channels;

var i = 0;
AbstractClass instance = new ConcreteClassB();

instance.Method();
instance.Operation();

// Delay.
Console.ReadKey();

// Конкретный класс A.
internal class ConcreteClassA
{
    //public ConcreteClassA(string msg) => Console.WriteLine($"ConcreteClassA - {msg}");

    public void Operation() => Console.WriteLine("ConcreteClassA.Operation");
}

// Абстрактный класс.
internal abstract class AbstractClass : ConcreteClassA
{
    //protected AbstractClass(string msg) : base(msg) => Console.WriteLine($"AbstractClass - {msg}");
    public abstract void Method();
}

// Конкретный класс B.
internal class ConcreteClassB : AbstractClass
{
    //public ConcreteClassB(string msg) : base(msg) => Console.WriteLine($"ConcreteClassB - {msg}");
    public override void Method() => Console.WriteLine("ConcreteClassB.Method");
}
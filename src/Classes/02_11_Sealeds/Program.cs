
using Sealeds;

new Aaa().Method();

// Герметизированные классы.

internal sealed class SealedClass
{
    public int x;
    public int y;
}

// Попытка наследования от SealedClass приводит к ошибке компилятора.

internal class DerivedClass //: SealedClass   // Error
{
}


// Sealed (Герметизированные) методы.

internal class ClassA
{
    public virtual void Method1() => Console.WriteLine("ClassA.Method1");
    public virtual void Method2() => Console.WriteLine("ClassA.Method2");
}

internal class ClassB : ClassA
{
    public sealed override void Method1() => Console.WriteLine("ClassB.Method1");
    public override void Method2() => Console.WriteLine("ClassB.Method2");
}

internal class ClassC : ClassB
{
    // Попытка переопределить Method1 приводит к ошибке компилятора: CS0239.
     //public override void Method1() { Console.WriteLine("ClassC.Method1"); }

    // Переопределение Method2 позволено.
    public override void Method2() { Console.WriteLine("ClassC.Method2"); }
}
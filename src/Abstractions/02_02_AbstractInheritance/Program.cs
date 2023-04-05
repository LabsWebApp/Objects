// Абстрактный класс может быть унаследован от абстрактного класса.
// Реализация абстрактного метода из базового абстрактного класса, в производном абстрактном классе - не обязательна.

AbstractClassA instance = new ConcreteClass();

instance.OperationA();

// instance.OperationB();  // Вопрос: почему недоступен данный метод?

// Delay.
Console.ReadKey();

// Абстрактный класс A.
internal abstract class AbstractClassA
{
    public abstract void OperationA();
}

// Абстрактный класс B.
internal abstract class AbstractClassB : AbstractClassA
{
    public abstract void OperationB();
}

// Конкретный класс.
internal class ConcreteClass : AbstractClassB
{
    public override void OperationA() => Console.WriteLine("ConcreteClass.OperationA");

    public override void OperationB() => Console.WriteLine("ConcreteClass.OperationB");
}
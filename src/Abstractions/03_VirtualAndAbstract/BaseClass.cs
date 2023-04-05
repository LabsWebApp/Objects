namespace VirtualAndAbstract;

internal abstract class AbstractBaseClass
{
    // 1.
    // Обычный метод передается производному классу как при наследовании от конкретного класса.
    public void SimpleMethod() => Console.WriteLine("AbstractBaseClass.SimpleMethod");

    // 2.
    // Виртуальный метод передается производному классу как при наследовании от конкретного класса.
    public virtual void VirtualMethod() => Console.WriteLine("AbstractBaseClass.VirtualMethod");

    // 3.
    // Абстрактный метод - реализуется в производном классе.
    public abstract void AbstractMethod();

    // 4.
    // Абстрактное свойство
    public abstract string? Name { get; set; }
}
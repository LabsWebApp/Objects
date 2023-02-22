DemoClass demo = new DemoClass();

demo.Method();
//demo.MethodWithDefault();
((IInterface)demo).MethodWithDefault();
(demo as IInterface).MethodWithDefault();

//Delay.
Console.ReadKey();

internal interface IInterface
{
    void Method();
    void MethodWithDefault() => Console.WriteLine("Метод с реализацией по умолчанию в Интерфейсе");
}

internal class DemoClass : IInterface
{
    public void Method()
    {
        Console.WriteLine("Метод - реализация Интерфейса.");
    }
}
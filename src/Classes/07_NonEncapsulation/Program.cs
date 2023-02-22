// Объект не может скрывать (инкапсулировать) ничего, от другого объекта того же класса.

DemoClass demo = new DemoClass();
demo.CallMethod();
//demo.Method(); // Недопустимо.

// Delay.
Console.ReadKey();

internal class DemoClass
{
    private DemoClass _demo = null;

    private void Method() => Console.WriteLine("Hello");

    public void CallMethod()
    {
        _demo = new DemoClass();

        // private метод виден на экземпляре!
        _demo.Method();
    }
}
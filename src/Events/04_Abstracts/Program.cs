namespace Abstracts;

public delegate void EventDelegate();

internal interface IInterface
{
    event EventDelegate DemoEvent; // Абстрактное событие.
}

public class BaseClass : IInterface
{
    private EventDelegate? _demoEvent;

    public virtual event EventDelegate DemoEvent // Виртуальное событие.
    {
        add => _demoEvent += value;
        remove => _demoEvent -= value;
    }

    public void InvokeEvent() => _demoEvent?.Invoke();
}

public class DerivedClass : BaseClass
{
    public override event EventDelegate DemoEvent // Переопределенное событие.
    {
        add
        {
            base.DemoEvent += value;
            Console.WriteLine($"К событию базового класса был прикреплен обработчик - {value.Method.Name}");
        }
        remove
        {
            base.DemoEvent -= value;
            Console.WriteLine($"От события базового класса был откреплен обработчик - {value.Method.Name}");
        }
    }
}

internal class Program
{
    // Методы обработчики события.

    private static void Handler1() => Console.WriteLine("Обработчик события 1");

    private static void Handler2() => Console.WriteLine("Обработчик события 2");

    private static void Main()
    {
        var instance = new DerivedClass();

        // Присоединение обработчиков событий.
        instance.DemoEvent += Handler1;
        instance.DemoEvent += Handler2;

        // Метод который вызывает событие.
        instance.InvokeEvent();

        Console.WriteLine(new string('-', 20));

        // Открепляем Handler2().
        instance.DemoEvent -= Handler2;
        instance.InvokeEvent();

        // Delay.
        Console.ReadKey();
    }
}
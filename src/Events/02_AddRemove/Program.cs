using System.Threading.Channels;

namespace AddRemove;

public delegate void EventDelegate();

internal class DemoClass
{
    private EventDelegate? _demoEvent;

    // Реализация методов доступа add и remove для события.
    public event EventDelegate DemoEvent
    {
        add
        {
            Console.WriteLine($"Add: {value.GetInvocationList().Aggregate(string.Empty, (x, y) => x + "\n\t" + y.Method)}");
            _demoEvent += value;
        }
        remove
        {
            Console.WriteLine($"Remove: {value.GetInvocationList().Aggregate(string.Empty, (x, y) => x + "\n\t" + y.Method)}");
            _demoEvent -= value;
        }
    }

    public void InvokeEvent() => _demoEvent?.Invoke();
}

internal class Program
{
    // Методы обработчики события.

    private static void Handler1() => Console.WriteLine("Обработчик события 1");

    private static void Handler2() => Console.WriteLine("Обработчик события 2");

    private static void Main()
    {
        var instance = new DemoClass();

        // Подписка на событие.
        instance.DemoEvent += Handler1;
        instance.DemoEvent += Handler2;
        instance.DemoEvent += () => Console.WriteLine("Обработчик события anonymous");

        // Метод который вызывает событие.
        instance.InvokeEvent();

        Console.WriteLine(new string('-', 20));

        // Открепляем Handler2().
        instance.DemoEvent -= Handler2;
        // instance.DemoEvent -= () => Console.WriteLine("Обработчик события anonymous");
        instance.InvokeEvent();

        // Delay.
        Console.ReadKey();
    }
}
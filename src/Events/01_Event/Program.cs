// События.

namespace Events;

public delegate void EventDelegate();

public class DemoClass
{
    public event EventDelegate? DemoEvent;

    public void InvokeEvent() => DemoEvent?.Invoke();
}

class Program
{
    // Методы обработчики события.

    private static void Handler1() => Console.WriteLine("Обработчик события 1");

    private static void Handler2() => Console.WriteLine("Обработчик события 2");

    private static void Main()
    {
        DemoClass instance = new();

        // Присоединение обработчиков событий. (Подписка на событие)
        instance.DemoEvent += new EventDelegate(Handler1);
        instance.DemoEvent += Handler2;

       // Console.WriteLine(instance.DemoEvent);

        // Метод который вызывает событие.
        instance.InvokeEvent();

        Console.WriteLine(new string('-', 20));

        // Открепляем Handler2().
        instance.DemoEvent -= new EventDelegate(Handler2);

        instance.InvokeEvent();

        // Delay.
        Console.ReadKey();
    }
}
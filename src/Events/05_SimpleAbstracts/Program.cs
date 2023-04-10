namespace SimpleAbstracts;

public delegate void EventDelegate();

internal interface IInterface
{
    event EventDelegate DemoEvent;
    void InvokeEvent();
}

public class BaseClass : IInterface
{
    /*
     * Следуйте рекомендациям по проектированию .NET. Не объявляйте виртуальные события
     * в базовом классе. Переопределенные события в производном классе
     * имеют неопределенное поведение. Компилятор C# может обработать это неправильно,
     * и невозможно предсказать, сможет ли подписчик на производное событие подписаться
     * на событие базового класса.
     */
    public virtual event EventDelegate? DemoEvent;
    public virtual void InvokeEvent() => DemoEvent?.Invoke();
}

public class DerivedClass : BaseClass
{
    public override event EventDelegate? DemoEvent;

    public override void InvokeEvent()
    {
        Console.WriteLine("Произошло событие:");
        DemoEvent?.Invoke();
        //base.InvokeEvent();
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

        //Метод который вызывает событие.
        instance.InvokeEvent();

        Console.WriteLine(new string('-', 20));

        // Открепляем Handler2().
        instance.DemoEvent -= Handler2;
        instance.InvokeEvent();

        // Delay.
        Console.ReadKey();
    }
}
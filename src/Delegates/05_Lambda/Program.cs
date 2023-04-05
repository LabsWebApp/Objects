// Анонимные лямбда методы.
namespace Lambda;

// Создаем класс делегата.
internal delegate void Delegate();

internal class Program
{
    private static void Main()
    {
        // Создаем экземпляр класса-делегата Delegate и сообщаем с ним анонимный метод.
        Delegate? simpleDelegate = null;
        simpleDelegate = delegate
        {
            Console.WriteLine("Hello world!");
        };
        // Вызов анонимного метода, сообщенного с делегатом.
        simpleDelegate();
        Console.WriteLine("****");

        simpleDelegate += () => { Console.WriteLine("add"); }; // Java -> вместо =>
        simpleDelegate += () => { Console.WriteLine("add"); };
        simpleDelegate?.Invoke();
        Console.WriteLine("****");
        simpleDelegate -= () => { Console.WriteLine("add"); };

        simpleDelegate?.Invoke();

        // Delay.
        Console.ReadKey();
    }
}
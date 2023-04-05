namespace DelegateDelegate;

internal delegate Delegate2 Delegate1();  // 1.

internal delegate void Delegate2();       // 2.

internal class Program
{
    public static Delegate2 Method1()     // 1.
    {
        Console.WriteLine("Готовим Delegate2");
        return new Delegate2(Method2);
    }

    public static void Method2()          // 2.
    {
        Console.WriteLine("Выполняем Method2");
        Console.WriteLine("Hello world!");
    }

    private static void Main()
    {

        var delegate1 = new Delegate1(Method1);

        //Delegate2 delegate2 = delegate1();
        Delegate2 delegate2 = delegate1.Invoke();

        delegate2();

        delegate1.Invoke();
        delegate1.Invoke().Invoke();
        

        // Delay.
        Console.ReadKey();
    }
}
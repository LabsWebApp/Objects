namespace Functional;

internal delegate Delegate3 Functional(Delegate1 delegate1, Delegate2 delegate2);

internal delegate string Delegate1();

internal delegate string Delegate2();

internal delegate string Delegate3();

internal class Program
{
    private static Delegate3 MethodF(Delegate1 delegate1, Delegate2 delegate2) =>
        () => delegate1.Invoke() + delegate2.Invoke();

    private static string Method1() { return "Hello "; }
    private static string Method2() { return "world!"; }

    private static void Main()
    {
        var functional = new Functional(MethodF);

        var delegate3 = functional.Invoke(new Delegate1(Method1), new Delegate2(Method2));

        Console.WriteLine(delegate3.Invoke());

        // Delay.
        Console.ReadKey();
    }
}
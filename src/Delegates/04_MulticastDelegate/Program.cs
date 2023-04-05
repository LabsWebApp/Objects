using static System.Console;
// Комбинированные (групповые) делегаты.

namespace MulticastDelegate;

internal class Program
{
    private delegate void Delegate();

    private delegate int IntDelegate(int i);


    private static void Method1() => WriteLine("Method1");
    private static void Method2() => WriteLine("Method2");
    private static void Method3() => WriteLine("Method3");

    private static int Method4(int i)
    {
        WriteLine("Method4 i = " + i);
        return ++i;
    }

    public static void Main()
    {
        IntDelegate intDelegate1 = Method4;
        IntDelegate intDelegate2 = Method4;

        // Комбинируем делегаты.
        IntDelegate baseIntDelegate = intDelegate1 + intDelegate2;

        WriteLine(baseIntDelegate.Invoke(10));
        WriteLine("*****");
        ReadKey();

        Delegate? baseDelegate = null;
        var simpleDelegate1 = new Delegate(Method1);
        Delegate simpleDelegate2 = Method2;
        Delegate simpleDelegate3 = Method3;

        //simpleDelegate3 += simpleDelegate1;
        baseDelegate = simpleDelegate1 + simpleDelegate2 + simpleDelegate3;

        //Console.WriteLine(baseDelegate.GetInvocationList() == (baseDelegate as System.MulticastDelegate).GetInvocationList());
        //Console.WriteLine(baseDelegate is System.MulticastDelegate);
        //Console.WriteLine((baseDelegate as System.MulticastDelegate) is System.Delegate);

        foreach (var d in (baseDelegate as System.MulticastDelegate).GetInvocationList())
        {
            Console.WriteLine(d.GetType().FullName);
        }

        baseDelegate += simpleDelegate1;
        
        baseDelegate.Invoke();
        WriteLine("*****");
        baseDelegate -= simpleDelegate1;

        baseDelegate?.Invoke();

        while (true)
        {
            WriteLine("Введите число от 1 до 8");

            switch (ReadLine())
            {
                case "1":
                {
                    simpleDelegate1.Invoke();
                    break;
                }
                case "2":
                {
                    simpleDelegate2.Invoke();
                    break;
                }
                case "3":
                {
                    simpleDelegate3.Invoke();
                    break;
                }
                case "4":
                {
                    var simpleDelegate4 = (baseDelegate - simpleDelegate1)!;
                    simpleDelegate4.Invoke();
                    break;
                }
                case "5":
                {
                    var simpleDelegate5 = (baseDelegate - simpleDelegate2)!;
                    simpleDelegate5.Invoke();
                    break;
                }
                case "6":
                {
                    var simpleDelegate6 = (baseDelegate - simpleDelegate3)!;
                    simpleDelegate6.Invoke();
                    break;
                }
                case "7":
                {
                    var simpleDelegate7 = (baseDelegate - simpleDelegate3 - simpleDelegate1 - simpleDelegate2);
                    WriteLine(simpleDelegate7 is {});
                    simpleDelegate7?.Invoke();
                    break;
                }
                case "8":
                {
                    baseDelegate.Invoke();
                    break;
                }
                default:
                {
                    WriteLine("Вы ввели недопустимое значение.");
                    return;
                }
            }
        }
    }
}
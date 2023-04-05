using static System.Console;
// Анонимные (лямбда) методы.

namespace Delegate;

// Создаем класс делегата.
public delegate void Delegate(ref int a, in int b, out int c);

public delegate void Delegate1(int a, int b, int c);
public delegate int Delegate2(int a);

internal class IntWrapper
{
    public int X { get; set; }
}

internal class Program
{
    private static void M(int i) => i = 99;

    private static void M(IntWrapper i)
    {
        //i = new IntWrapper();
        i.X = 99;
    }

    private static void Main()
    {
        //int i = 5;
        //var i2 = new IntWrapper();
        //i2.X = 5;

        //M(i);
        //M(i2);

        //WriteLine(i);
        //WriteLine(i2.X);

        //ReadKey();


        int summand1 = 1, summand2 = 2;

        Delegate simpleDelegate = delegate (ref int a, in int b, out int c)
        {
            a++;
            c = a + b;
        };

        simpleDelegate.Invoke(ref summand1, in summand2, out var sum);

        WriteLine($"{summand1} + {summand2} = {sum}");

        ReadKey();
        simpleDelegate = (ref int a, in int b, out int c) =>
                        {
                            a++;
                            //b++;
                            c = a + b;
                        };
        WriteLine("****");
        simpleDelegate.Invoke(ref summand1, in summand2, out sum);
        WriteLine($"{summand1} + {summand2} = {sum}");

        simpleDelegate.Invoke(ref summand1, in summand2, out sum);

        WriteLine($"{summand1} + {summand2} = {sum}");
        ReadKey();



        Delegate1 incrInt = (a, _, _) =>
                            {
                                a++;
                            };
        incrInt.Invoke(summand1, summand2, sum);
        //simpleDelegate(ref summand1, summand2, out sum);

        WriteLine($"{summand1} + {summand2} = {sum}");

        Delegate2 d2 = i => i++;

        // Delay.
        ReadKey();
    }
}
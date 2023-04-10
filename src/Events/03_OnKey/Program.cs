namespace OnKey;

public delegate void PressKeyEventHandler();

public class Keyboard
{
    public event PressKeyEventHandler? PressKeyA;
    public event PressKeyEventHandler? PressKeyB;
    //  C ... Z

    public void PressKeyAEvent() =>
        PressKeyA?.Invoke(); // вызываем метод Invoke на событии

    public void PressKeyBEvent() => PressKeyB?.Invoke();

    public void Start()
    {
        while (true)
        {
            var s = Console.ReadLine();
            switch (s)
            {
                case "a":
                case "A":
                    PressKeyAEvent();
                    break;
                case "b":
                case "B":
                    PressKeyBEvent();
                    break;
                case "exit":
                    goto Exit;

                default:
                    Console.WriteLine($"Нет обработчика нажатия на клавишу {s}");
                    break;
            }
        }
        Exit:
        Console.WriteLine("Exit!");
    }
}

internal class Program
{
    // Методы обработчики события.

    private static void PressKeyA_Handler()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine();
        Console.WriteLine("    X    ");
        Console.WriteLine("   X X   ");
        Console.WriteLine("  X   X  ");
        Console.WriteLine(" XXXXXXX ");
        Console.WriteLine("X       X");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    private static void PressKeyB_Handler()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine("XXXXX  ");
        Console.WriteLine("X    X ");
        Console.WriteLine("XXXXXX ");
        Console.WriteLine("X     X");
        Console.WriteLine("XXXXXX ");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static void Main()
    {
        var keyboard = new Keyboard();

        // Подписка на событие.
        keyboard.PressKeyA += PressKeyA_Handler;
        keyboard.PressKeyB += PressKeyB_Handler;

        // Запуск метода, который будет следить за нажатием клавиш 
        keyboard.Start();

        Console.ReadKey();
    }
}
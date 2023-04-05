namespace @delegate;

// Создаём класс-делегата с именем Delegate,
// метод, который будет сообщен с экземпляром данного класса-делегата, 
// не будет ничего принимать и не будет ничего возвращать.
public delegate void Delegate();  //1

// Класс, метод которого будет сообщен с делегатом.
internal static class StaticClass
{
    static StaticClass() => Console.WriteLine("Создан \"невидимый\" экземпляр");

    // Создаем статический метод, который планируем сообщить с делегатом.
    public static void Method() => 
        Console.WriteLine("StaticClass: Строку вывел метод сообщенный с делегатом.");
}

// Класс, метод которого будет сообщен с делегатом.
internal class Class
{
    public void Method() => Console.WriteLine("Class [not static]: Строку вывел метод сообщенный с делегатом.");
}

internal class Program
{
    public static void Main()
    {
        Delegate? simpleDelegate = null;

        simpleDelegate = StaticClass.Method; // Создаем экземпляр делегата. (2)

        Console.ReadKey();

        Class instance = new();

        simpleDelegate = simpleDelegate + instance.Method;
        //simpleDelegate = instance.Method + simpleDelegate;

        simpleDelegate?.Invoke(); // Вызываем метод сообщенный с делегатом. (3)
        Console.WriteLine();
        simpleDelegate!();        // Другой способ вызова метода сообщенного с делегатом. (3')

        // Delay
        Console.ReadKey();
    }
}
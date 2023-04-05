namespace Parameterized;

// Создаём класс-делегата с именем Delegate,
// метод, который будет сообщен с экземпляром данного класса-делегата, 
// будет принимать один параметр типа object и будет возвращать тип string.
public delegate string Delegate(object name);   //1

// Класс, метод которого будет сообщен с делегатом.
internal class SimpleClass
{
    public string Method(object name) => "Hello " + name;

    public string Method(int id) => "Привет " + id;
}

internal class Program
{
    public static void Main()
    {
        var instance = new SimpleClass();

        Delegate simpleDelegate = instance.Method; // Создаем экземпляр делегата и сообщаем с ним метод. (2)

        // Вызываем метод сообщенный с делегатом. (3)
        var greeting = simpleDelegate.Invoke("Jeffrey Richter");

        Console.WriteLine(greeting);

        int i = 55;
        greeting = simpleDelegate(i); // Другой способ вызова метода сообщенного с делегатом. (3')

        Console.WriteLine(greeting);

        greeting = instance.Method(i);
        Console.WriteLine(greeting);

        // Delay
        Console.ReadKey();
    }
}
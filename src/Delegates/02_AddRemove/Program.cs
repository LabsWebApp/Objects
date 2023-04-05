using static System.Console;

namespace AddRemove;

// Создаём класс-делегата с именем Delegate,
// метод, который будет сообщен с экземпляром данного класса-делегата, 
// не будет ничего принимать и не будет ничего возвращать.
public delegate void Delegate();  //1

// Класс, методы которого будут сообщены с делегатом.
internal class SimpleClass
{
    public void Method() => WriteLine("Строку вывел метод сообщенный с делегатом.");
    public static void StaticMethod() => WriteLine("Строку вывел метод сообщенный с делегатом. [static]");
}

internal class Program
{
    public static void Main()
    {
        Delegate? simpleDelegate = null;
        var instance = new SimpleClass();

        simpleDelegate = instance.Method; // Создаем экземпляр делегата. (2)
        simpleDelegate += SimpleClass.StaticMethod;
        simpleDelegate();
        // simpleDelegate = simpleDelegate + SimpleClass.StaticMethod;
        simpleDelegate -= instance.Method;
        simpleDelegate -= SimpleClass.StaticMethod;
        simpleDelegate?.Invoke(); // Вызываем метод сообщенный с делегатом. (3)
        //simpleDelegate();         //Другой способ вызова метода сообщенного с делегатом. (3')

        instance.Method();

        // Delay
        ReadKey();
    }
}
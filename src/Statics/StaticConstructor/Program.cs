// 1 Вариант. (Вызывается только Статический конструктор.)
NotStaticClass.StaticMethod();

// 2 Вариант. (Вызываются оба Конструктора.)
//new NotStaticClass().NotStaticMethod();
//NotStaticClass.StaticMethod();

// Delay.
Console.ReadKey();


internal class NotStaticClass
{
    // Контруктор экземпляра, вызывается только при создании экземпляра класса.
    public NotStaticClass() => Console.WriteLine("Constructor.");

    // Статический конструктор вызывается в любом случае, 
    // как при обращении к статическому члену, так и при создании экземпляра класса.
    static NotStaticClass() => Console.WriteLine("Static Constructor.");

    // Статический метод.
    public static void StaticMethod() => Console.WriteLine("StaticMethod");

    public void NotStaticMethod() => Console.WriteLine("NotStaticMethod");
}
// Применяем конструктор по умолчанию.
Point pointA = new Point();
Console.WriteLine($"pointA.X = {pointA.X} pointA.Y = {pointA.Y}");

Console.WriteLine(new string('-', 30));

// Применяем конструктор с параметрами.
Point pointB = new Point(100, 200);
Console.WriteLine($"pointB.X = {pointB.X} pointA.Y = {pointB.Y}");

// Delay.
Console.ReadKey();

internal class Point
{
    // Поля.
    private readonly int _x;
    private readonly int _y;

    // Свойства.
    public int X => _x;


    public int Y => _y;

    //public Point(){}

    // Конструктор по умолчанию, инициализирует поля значениями по умолчанию.
    public Point() => Console.WriteLine("Конструктор по умолчанию!");

    //Пользовательский конструктор, инициализирует поля значениями заданными пользователем.
    public Point(int x, int y)
    {
        Console.WriteLine("Пользовательский конструктор!");
        _x = x;
        _y = y;
    }
}


internal class BoxI
{
    public int I;
}
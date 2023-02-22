// Применяем конструктор по умолчанию.  
Point pointA = new Point();                                              //  Снять 
Console.WriteLine($"pointA.X = {pointA.X} pointA.Y = {pointA.Y}");       //  комментарий 

//Console.WriteLine(new string('-', 30));

// Применяем конструктор с параметрами.
//Point pointB = new Point(100, 200);
//Console.WriteLine($"pointB.X = {pointB.X} pointA.Y = {pointB.Y}");


// Delay.
Console.ReadKey();

internal class Point
{
    // Поля.
    private int _x, _y;

    // Свойства.
    public int X => _x;

    public int Y => _y;

    // Конструктор по умолчанию, инициализирует поля значениями по умолчанию.
    public Point() {}
    //public Point() => Console.WriteLine("Конструктор по умолчанию!");

    // Пользовательский конструктор, инициализирует поля значениями заданными пользователем.
    public Point(int x, int y)
    {
        Console.WriteLine("Пользовательский конструктор!");
        this._x = x;
        this._y = y;
    }
}
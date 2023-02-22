namespace Constructors;

// Конструктор может вызывать в том же самом объекте другой конструктор с помощью ключевого слова this.

internal class Point
{
    #region Поля
    private int x, y;
    private string? name;
    #endregion

    #region Свойства
    public int X => x;

    public int Y => y;

    public string? Name => name;
    #endregion

    #region Конструкторы
    public Point(int x, int y)
    {
        Console.WriteLine("Конструктор с двумя параметрами.");
        this.x = x;
        this.y = y;
    }

    // Использование ключевого слова this в конструкторе приводит к вызову
    // конструктора с двумя параметрами.
    public Point(string name)
        : this(300, 400)
    {
        Console.WriteLine("Конструктор с одним параметром.");
        this.name = name;
    }

    //Использование ключевого слова base в конструкторе не допускается.
    //public Point(int xy)
    //{
    //    if (xy < 0) throw new ArgumentException("Отрицательные координаты", nameof(xy));
    //    Console.WriteLine("Конструктор с одним параметром.");
    //    this.name = $"({xy}, {xy})";
    //    base(xy, xy);
    //}
    #endregion
}
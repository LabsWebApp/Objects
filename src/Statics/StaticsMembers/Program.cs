NotStaticClass instance1 = new NotStaticClass(1);
NotStaticClass instance2 = new NotStaticClass(2);

instance1.Method();
instance2.Method();

// На классе-объекте NotStaticClass, обращаемся к статическому полю - field
NotStaticClass.Field = 1;

instance1.Method();
instance2.Method();

Console.WriteLine(NotStaticClass.Property);
Console.WriteLine(NotStaticClass.ReadonlyField);

Console.ReadKey();

internal class NotStaticClass
{
    private readonly int _id;
    public static int Field;

    // Конструктор.
    public NotStaticClass(int id) => _id = id;

    public void Method() => Console.WriteLine($"Instance{_id}.Field = {Field}");

    public static void StaticMethod()
    {
        //Console.WriteLine($"Instance.Id = {_id}");

        Console.WriteLine("В статических методах нельзя обращаться к не статическим полям.");
    }


    // Статическое поле.
    private static int _field;
    // Статическое свойство.
    public static int Property
    {
        get { return _field; }
        set { _field = value; }
    }

    // Статические поля readonly должны быть инициализированы в конструкторе.
    private static readonly long _readonlyField = 2;

    // Статическое свойство только для чтения.
    public static long ReadonlyField
    {
        get { return NotStaticClass._readonlyField; }
    }

    // Статический конструктор.        
    static NotStaticClass() => _readonlyField = 1;

    // Статические методы могут быть перегружены.
    public static void Method(int s) => Console.WriteLine("Перегруженный статический метод, неcтатического Method " + s + "(число)");
    public static void Method(string s) => Console.WriteLine("Перегруженный статический метод, неcтатического Method " + s + "(строка)");
}
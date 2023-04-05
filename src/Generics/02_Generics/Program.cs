// ReSharper disable All
var generics = new Generics<int, string?>(10, "name");

Console.WriteLine(generics.GetType().FullName);

Console.Read();

internal class Generics<TType1, TType2>
{
    // Поля
    private TType1? _variable1;

    private TType2? _variable2;

    // Конструктор.
    public Generics(TType1? argument1, TType2? argument2)
    {
        this.Variable1 = argument1;
        this.Variable2 = argument2;
    }

    // Свойства.
    public TType1? Variable1
    {
        get => _variable1;
        set => _variable1 = value;
    }

    public TType2? Variable2
    {
        get => _variable2;
        set => _variable2 = value;
    }
}
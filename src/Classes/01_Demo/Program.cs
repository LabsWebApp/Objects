// 1. Создаем экземпляр класса DemoClass (по сильной ссылке).
// 2. Создаем экземпляр класса DemoClass с именем instance.
// 3. Инстанцируем / класс DemoClass.
// 4. Создаем переменную с именем instance, типа DemoClass и присваиваем ей адрес экземпляра на куче. 
// (instance - является ссылкой на экземпляр класса DemoClass построенный на куче)

DemoClass instance = new DemoClass();

instance.Method();

Console.WriteLine(DemoClass.PublicConstInt.GetType().Name);

//instance.WriteOnlyStringProperty = "Hello";

internal class DemoClass : object
{
    // константы
    public const int PublicConstInt = 1;

    // поля
    public readonly string StringField = "StringField";

    // свойства
    public string? GetStringProperty { get; } = "StringProperty0";


    private string? _stringField1;
    public string? DemoStringProperty
    {
        // Метод-аксессор -  accessor  (getter)
        get { return _stringField1; }
        // Метод-мутатор - mutator  (setter)
        set { _stringField1 = value; }
    }

    private string? _stringField2;
    public string? SimpleDemoStringProperty
    {
        get => _stringField2;
        set => _stringField2 = value;
    }

    public string? GetSetStringProperty { private get; set; }

    private string? _significanceField = null;
    public string SignificanceField 
    {
        set // SignificanceField = "Goodbye"
        {
            if (value == "Goodbye")
                Console.WriteLine("Вы ввели недопустимое значение. Повторите попытку.");
            else
                _significanceField = value;
        }

        get // var x = SignificanceField
        {
            switch (_significanceField)
            {
                case null:
                    return "В поле SignificanceField отсутствуют данные.";
                case "hello world":
                    return _significanceField.ToUpper() + "!";
                default:
                    return _significanceField;
            }
        }
    }

    public string? GetInitStringProperty { get; init; }
    //public string? GetInitStringProperty { get; }

    //public string? StringProperty5 { set; }
    public string? WriteOnlyStringProperty
    {
        set => Console.WriteLine(value);
    }

    public void Method() => Console.WriteLine(GetStringProperty);

    public DemoClass() => GetStringProperty = "StringProperty";
}
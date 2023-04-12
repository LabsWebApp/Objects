// Создание экземпляра структурного типа с вызовом конструктора по умолчанию.
DemoStruct instance = new ();

//instance.Field = 1;

instance.Show();

var instance2 = new DemoStruct { Field = 11, Value = 55 };

instance2.Show();

(instance2 with { Value = 99 }).Show();

// Delay.
Console.ReadKey();

struct DemoStruct
{
   // public int Field { get; set; }

    public int Value;



    public int Field = 10;

    public DemoStruct()
    {
        Field = 66;
    }

    public void Show() => Console.WriteLine(ToString());

    public override string ToString() => $"Field = {Field}\tValue = {Value}";
}
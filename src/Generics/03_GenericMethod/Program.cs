// Универсальные шаблоны. (Универсальный метод)

var instance = new A();

instance.Method<string>("Hello world!");

instance.Method("Привет мир!");

instance.Method(55);
instance.Method(55_000_000_000);

Console.Read();

internal class A
{
    public void Method<T>(T argument)
    {
        T variable = argument;
        Console.WriteLine($"{variable} - {variable!.GetType().FullName}");
    }
}
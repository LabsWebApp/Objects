// Структуры. Наследование.

// Все структуры неявно наследуются от абстрактного класса - ValueType

// От структур нельзя наследоваться.

DemoStruct instance = new();

ValueType valueType = instance as ValueType;

Console.WriteLine($"instance  = {instance.GetHashCode()}");
Console.WriteLine($"valueType = {valueType.GetHashCode()}");

// Delay.
Console.ReadKey();

interface IInterface
{
    void Method();
}

struct DemoStruct : IInterface // : ValueType
{
    public void Method() => Console.WriteLine("Method");
}
DerivedClass instance = new DerivedClass();

instance.field1 = 1;
instance.field2 = 2;
instance.field3 = 3;

instance.field4 = 4;
instance.field5 = 5;

// Приведение экземпляра класса DerivedClass к базовому типу BaseClass.
BaseClass newInstance = (BaseClass)instance; // Upcast

Console.WriteLine(newInstance.field1);
Console.WriteLine(newInstance.field2);
Console.WriteLine(newInstance.field3);

//Console.WriteLine(newInstance.field4);
//Console.WriteLine(newInstance.field5);


// Проверка.
Console.WriteLine($"instance GetHashCode     {instance.GetHashCode()}");
Console.WriteLine($"newInstance GetHashCode  {newInstance.GetHashCode()}");


// Delay.
Console.ReadKey();


internal class BaseClass
{
    public int field1;
    public int field2;
    public int field3;
}

internal class DerivedClass : BaseClass
{
    public int field4;
    public int field5;
}
// Универсальные шаблоны. (обобщения, дженерики)

// Создаем экземпляр класса Class и в качестве параметра типа передаем тип int.
var instance1 = new Class<int>();
instance1.Method();

// Создаем экземпляр класса Class и в качестве параметра типа передаем тип long.
var instance2 = new Class<long>();
instance2.Method();

// Создаем экземпляр класса Class и в качестве параметра типа передаем тип string.
var instance3 = new Class<string>
{
    Field = "ABC"
};
instance3.Method();

// Создаем экземпляр класса Class и в качестве параметра типа передаем тип string.
var instance4 = new Class<string>();
instance4.Method();

// Создаем экземпляр класса Class и в качестве параметра типа передаем тип
// Class с параметром типа int
var instance5 = new Class<Class<int>>
{
    Field = new()
};
instance5.Method();

Console.Read();

// Создаем класс с именем Class, параметризованный Указателем Места Заполнения Типом - T
internal class Class<T>
{
    public T? Field;

    public void Method() =>
        Console.WriteLine(Field?.GetType().FullName ?? "Какой-то ссылочный тип");
}
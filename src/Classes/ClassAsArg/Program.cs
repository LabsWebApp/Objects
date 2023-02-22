// Передача экземпляра класса в качестве аргумента метода

DemoClass my = new DemoClass();

DemoClass2 my2 = new DemoClass2();

my2.CallMethod(my);

// Задержка
Console.ReadKey();


internal class DemoClass
{
    public void Method() => Console.WriteLine("Вызван метод класса DemoClass");
}

internal class DemoClass2
{
    // Создаем метод с именем CallMethod, который принимает один аргумент
    // типа DemoClass и ничего не возвращает
    public void CallMethod(DemoClass my)
    {
        // В теле метода CallMethod, на 15 строке вызываем метод с именем Method аргумента my 
        my.Method();
    }
}
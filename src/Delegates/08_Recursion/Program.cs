// Рекурсия в лямбда операторах.

MeToo me = null; // Требуется обязательно присвоить null.!!!!!!!!
// Требуется отдельное(!!!!!!!!) присвоение ссылки на делегат с сообщенным лямбда оператором,
// в месте создания переменной, недопустимо сразу создавать лямбда оператор.

me = i =>
{
    Console.WriteLine($"Begin {--i}");

    if (i > 0)
    {
        me?.Invoke(i); 
        //me(i);
    }

    Console.WriteLine($"End {i}");
};

me(20);

Console.Read();

internal delegate void MeToo(int argument);
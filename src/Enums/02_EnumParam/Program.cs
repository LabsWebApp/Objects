// Enum, как аргумент метода

using EnumParam;

void EnumMethod(EnumType e)
{
    switch (e)
    {
        case EnumType.Zero:
            Console.WriteLine("Число 0");
            break;
        case EnumType.Two:
            Console.WriteLine("Число 2");
            break;
        case EnumType.Five:
            Console.WriteLine("Число 5");
            break;
        case EnumType.Ten:
            Console.WriteLine("Число 10");
            break;
        default: break;
    }
}

EnumMethod(EnumType.Five);

EnumType digit = EnumType.Ten;
EnumMethod(digit);

int i = (int)++digit;
Console.WriteLine(i);

Console.WriteLine(digit); // Переменная изменилась.
Console.WriteLine((int)EnumType.Ten); // Константа не изменилась.

digit++;
Console.WriteLine(digit);
digit = digit + 5;
Console.WriteLine(digit);
Console.WriteLine(digit.GetType());

// Недопустимо.
//digit = ++EnumType.One;
//digit = EnumType.One + EnumType.Two; 

// Delay.
Console.ReadKey();
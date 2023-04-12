// Переменной five типа EnumType может быть назначено любое значение, входящее в диапазон
// базового типа, значения не ограничены именованными константами.
EnumType five = (EnumType)5;

Console.WriteLine(five);

// Delay.
Console.ReadKey();


enum EnumType : byte
{
    Zero = 0,
    One = 1,
    Two = 2,
    Three = 3
}
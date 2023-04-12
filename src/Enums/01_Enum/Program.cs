// Перечисления.

// Перечисление - это набор именованных констант, которые хранят числовые значения.
// Перечисление определяет именованные константы, каждой из которых соответствует числовое значение.
// Все перечисления в C# происходят от единого Базового класса System.Enum

// При компиляции - компилятор подставляет вместо имен,
// установленные им в соответствие числовые значения. [имя] = [число]
// По умолчанию типом данных констант перечисления будет int.
// Можно использовать любой целый тип данных C#
// (byte, sbyte, short, ushort, int, uint, long, ulong, nint)

Enum one = EnumType.One;
Console.WriteLine(one);
Console.WriteLine(EnumType.One);
Console.WriteLine((int)EnumType.One);
Console.WriteLine((byte)(EnumType)one);

EnumType digit = EnumType.Zero;
Enum zero = digit;
Console.WriteLine(zero);

Console.WriteLine(new string('-', 10));

for (EnumType number = EnumType.Zero; number <= EnumType.Two; number++)
    Console.WriteLine(number);

// Delay.
Console.ReadKey();


// Нельзя использовать любой системный целый тип данных C#
// (Byte, SByte, Int16, UInt16, Int32,UInt32, Int64, UInt64)
enum EnumType : byte // Явно указываем использовать тип byte.
{
    Zero = 0,
    One = 1,
    Two = 2,
    Three = 3
}


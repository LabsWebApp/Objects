// Перечисления. Форматированный вывод элементов перечисления

EnumType digit = EnumType.Ten;

Console.WriteLine("Число {0}", digit.ToString());

// Enum.Format() - Позволяет производить более точное форматирование за счет указания флага, 
// а также получать имена элементов перечисления по их числовым значениям

// Вывод в 16-ричном формате. Флаг "x" - hex (16-ричный формат) 
Console.WriteLine($"Hex значение {Enum.Format(typeof(EnumType), EnumType.Ten, "x")}");

// Вывод в 10-тичном формате. Флаг "D" - dec (10-тичный формат)
Console.WriteLine($"Dec значение {Enum.Format(typeof(EnumType), digit, "D")}");

// Вывод в строковом формате. Флаг "G" - str (Строковой формат)
Console.WriteLine($"Str значение {Enum.Format(typeof(EnumType), 10, "G")}");

// Delay.
Console.ReadKey();


enum EnumType
{
    Zero,  // = 0 
    One = 1,
    one = One,
    Two = 2,
    Three, // = 3
    Four,  // = 4
    Five = 5,
    //Six,
    Seven,
    Eight = 8,
    Nine,
    Ten = 10,
    Infinite = 255
}
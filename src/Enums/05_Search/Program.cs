// Поиск элемента перечисления по имени константы.

// Находим элемент перечисления по имени константы.
object element = Enum.Parse(typeof(EnumType), "Infinite");
EnumType number = (EnumType)element;

Console.WriteLine($"Значение константы {number}: {(byte)number}");

// Enum.IsDefined() - Позволяет определить, является ли символьная строка элементом перечисления? 
Console.WriteLine(Enum.IsDefined(typeof(EnumType), "one")
    ? "Да, перечисление содержит элемент с таким именем."
    : "Нет, перечисление не содержит элемент с таким именем.");

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
    Six = Nine,
    //Seven,
    Eight = 8, // Если не указать значение явно то на 13 строке будет ошибка!
    Nine,
    Ten = 10,
    Infinite = 255
}
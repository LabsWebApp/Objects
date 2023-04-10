﻿// Получение информации о количестве элементов перечисления.
// Получение всех элементов перечисления и их значений

// Enum.GetValues() - возвращает экземпляр System.Array, при этом каждому элементу массива 
// будет соответствовать член указанного перечисления.

// Помещаем в массив элементы перечисления.
Array array = Enum.GetValues(typeof(EnumType));

// Получаем информацию о количестве элементов в массиве.
Console.WriteLine($"Это перечисление содержит {array.Length} членов \n");

// Вывод на экран всех элементов перечисления
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Имя константы: {array.GetValue(i)}, значение {array.GetValue(i):D}");
}

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
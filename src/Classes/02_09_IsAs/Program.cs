﻿B b = new B();
A a = null;

// --------------------------------------------- is --------------------------------------------- 
// Оператор is - проверяет совместимость объекта с заданным типом. 
// Если предоставленный объект может быть приведен к предоставленному типу не вызывая исключение,
// выражение is принимает значение true.

// Например, в следующем коде определяется, является ли объект экземпляром типа A или типа, производного от A:

if (b is A)
{
    a = (A)b;
    Console.WriteLine("OK");
}
else
{
    a = null;
    Console.WriteLine("Что-то пошло не так(");
}

// --------------------------------------------- as---------------------------------------------  
// Оператор as используется для выполнения преобразований между совместимыми ссылочными типами.
// Оператор as подобен оператору приведения. Однако, если преобразование невозможно,
// as возвращает значение null, а не вызывает исключение(!).

// В общем виде логика работы оператора as представляет собой механизм использования оператора is
// только в сокращенном виде.

a = b as A;

Console.WriteLine(a.GetType().Name);

// Delay.
Console.ReadKey();

internal class A { /* ... */ }

internal class B : A { /* ... */ }
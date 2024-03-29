﻿// Упаковка и распаковка.

// Упаковка (Boxing) - преобразование структурного типа (типа значения) в ссылочный тип 
// (Object или любой другой тип интерфейса, реализуемый этим типом значения).
// Когда тип значения упаковывается средой CLR, она создает программу-оболочку значения внутри
// System.Object и сохраняет ее в управляемой куче.

// Распаковка (Unboxing) - преобразование ссылочного типа в структурный тип.
// Операция распаковки-преобразования извлекает тип значения из объекта.
// Перед распаковкой среда выполнения проверяет совместимость между объектом и структурой,
// в которую будет происходить распаковка.

short a = 25;

// Упаковка переменной - а  (Boxing).
object o = a;

Console.WriteLine(o.GetType());
Console.WriteLine(o.GetHashCode());

// Распаковка объекта (UnBoxing).
short b = (short)o;

// Распаковка должна производиться только в тот тип, из которого производилась упаковка.
// byte s = (byte)o;

// Delay.
Console.ReadKey();
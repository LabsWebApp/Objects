﻿namespace MultiInheritance;

// В C# допустимо множественное наследование только от интерфейсов.
// Множественное наследование реализации (т.е. от двух и более классов или структур) недопустимо.
// Допустимо множественное наследование от одного класса и многих интерфейсов.

internal class DerivedClass : BaseClass, IInterface1, IInterface2 /*, BaseClass*/
{
    public void Method1() => Console.WriteLine("Реализация метода Method1() из Interface1");

    public void Method2() => Console.WriteLine("Реализация метода Method2() из Interface2");
}
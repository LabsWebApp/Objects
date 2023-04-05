﻿namespace ExplicitImplementation;

internal class DerivedClass : IInterface1, IInterface2
{
    //public void Method() => Console.WriteLine("Реализация метода Method() из Interface1 и Interface2");
    void IInterface1.Method() =>Console.WriteLine("Реализация метода Method() из Interface1"); 
    void IInterface2.Method() => Console.WriteLine("Реализация метода Method() из Interface2");
}
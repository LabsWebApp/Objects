namespace Classes;

internal partial class PartialClass
{
    public PartialClass() => Console.WriteLine("Класс состоит из 3-ёх частей. [0. - Part]");

    // Объявление частичного метода.        
    partial void PartialMethod();

    partial void EmptyMethod();
}
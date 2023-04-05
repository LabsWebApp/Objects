namespace Classes;

internal partial class PartialClass
{
    public void MethodFromPart1() => Console.WriteLine("1. Part");

    // Определение частичного метода. 
    partial void PartialMethod() => Console.WriteLine("Вызван частичный метод - PartialMethod(). [0. - 1. - Part]\"");

    // Вызов частичного метода через метод обертку.
    public void CallPartialMethod()
    {
        PartialMethod();

        // При вызове нереализованного частичного метода, компилятор его проигнорирует 
        EmptyMethod();
    }

    #region Реализация частичных методов в других частях класса необязательна!
    //partial void EmptyMethod() =>
    //  Console.WriteLine("Реализация частичных методов в других частях класса PartialClass - необязательна!"); 

    #endregion
}
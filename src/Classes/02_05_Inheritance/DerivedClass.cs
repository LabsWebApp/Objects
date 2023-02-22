namespace Inheritance;

internal class DerivedClass : BaseClass
{
    public int DerivedField;

    // Конструктор по умолчанию.
    public DerivedClass(){}

    // Пользовательский конструктор.
    // Вызывается пользовательский конструктор базового класса, при этом не нужно, 
    // присваивать значения, унаследованным членам в конструкторе производного класса.
    public DerivedClass(int number1, int number2)
        : base(number1)
    {
        DerivedField = number2;
    }
}
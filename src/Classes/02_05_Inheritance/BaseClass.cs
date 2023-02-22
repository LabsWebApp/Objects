namespace Inheritance;

internal class BaseClass
{
    public int BaseNumber;

    // Конструктор по умолчанию.
    public BaseClass()
    {
    }

    // Пользовательский конструктор.
    public BaseClass(int number)
    {
        this.BaseNumber = number;
    }
}
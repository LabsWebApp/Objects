namespace Inheritance;

internal class BaseClass
{
    // Поля

    // Открытое поле.
    public string PublicField = "BaseClass.publicField";

    // Закрытое поле.
    private string privateField = "BaseClass.privateField";

    // Защищенное поле.
    protected string ProtectedField = "BaseClass.protectedField";
    
    // Метод
    public void Show() => Console.WriteLine(privateField);
}
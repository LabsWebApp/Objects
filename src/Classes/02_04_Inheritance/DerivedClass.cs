namespace Inheritance;

internal class DerivedClass : BaseClass
{
    //  онструктор.
    public DerivedClass()
    {
        // »змен€ем все доступные пол€ унаследованные от базового класса.
        Console.WriteLine(ProtectedField);
        PublicField = "DerivedClass.publicField";
        ProtectedField = "DerivedClass.protectedField";

        // privateField = "";
    }
}
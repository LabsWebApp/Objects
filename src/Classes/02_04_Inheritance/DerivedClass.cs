namespace Inheritance;

internal class DerivedClass : BaseClass
{
    // �����������.
    public DerivedClass()
    {
        // �������� ��� ��������� ���� �������������� �� �������� ������.
        Console.WriteLine(ProtectedField);
        PublicField = "DerivedClass.publicField";
        ProtectedField = "DerivedClass.protectedField";

        // privateField = "";
    }
}
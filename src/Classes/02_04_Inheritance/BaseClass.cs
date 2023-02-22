namespace Inheritance;

internal class BaseClass
{
    // ����

    // �������� ����.
    public string PublicField = "BaseClass.publicField";

    // �������� ����.
    private string privateField = "BaseClass.privateField";

    // ���������� ����.
    protected string ProtectedField = "BaseClass.protectedField";
    
    // �����
    public void Show() => Console.WriteLine(privateField);
}
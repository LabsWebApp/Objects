namespace VirtualAndAbstract;

internal class ConcreteDerivedClass : AbstractBaseClass
{
    // �������������� ����������� ����� VirtualMethod() �������� ������������ ������.
    // ���� �� �� ������������� ����������� �����, �� ����� ����������� ����� �� �������� ������.
    public override void VirtualMethod() => Console.WriteLine("DerivedClass.VirtualMethod();");

    // ��������� ����������� ����� AbstractMethod() �������� ������������ ������.
    public override void AbstractMethod() => Console.WriteLine("DerivedClass.AbstractMethod();");

    // ��������� ����������� getter & setter Name �������� ������������ ������.
    public override string? Name { get; set; }
}
namespace IoCTest;

internal class DemoClass
{
    public DemoClass()
    {
    }

    public DemoClass(int i)
    {
        Console.WriteLine($"MyClass(int i) called with i = {i}");
    }

    public DemoClass(string s = "default")
    {
        Console.WriteLine($"MyClass(string s = \"default\") called with s = {s}");
    }

    public DemoClass(int i, string s)
    {
        Console.WriteLine($"MyClass(int i, string s) called with i = {i} and s = {s}");
    }
}
var instance = new DemoStruct.Nested();
instance.Method();

var instance1 = new DemoStruct.NestedStruct();
instance1.Method();

// Delay.
Console.ReadKey();

internal struct DemoStruct
{
    public class Nested
    {
        public void Method() => Console.WriteLine("Nested");
    }

    public struct NestedStruct
    {
        public void Method() => Console.WriteLine("Nested struct");
    }
}
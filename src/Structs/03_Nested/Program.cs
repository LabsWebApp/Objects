
DemoStruct.Nested instance = new DemoStruct.Nested();
instance.Method();

DemoStruct.NestedRef instance2 = new DemoStruct.NestedRef();
instance2.Method();

// Delay.
Console.ReadKey();


struct DemoStruct
{
    public struct Nested
    {
        public void Method() => Console.WriteLine("Nested");
    }

    public class NestedRef
    {
        public void Method() => Console.WriteLine("NestedRef");
    }
}
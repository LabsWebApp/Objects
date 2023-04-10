DemoStruct st = new DemoStruct();

// Упаковка (Boxing).
ValueType boxed = st;

// Распаковка объекта (UnBoxing).
DemoStruct unBoxed = (DemoStruct)boxed;

// Delay.
Console.ReadKey();


struct DemoStruct //: ValueType
{
    public void Method() => Console.WriteLine("Method");
}
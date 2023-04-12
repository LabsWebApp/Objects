DemoStruct st;
st.Method();

// Упаковка (Boxing).
IInterface boxed = st;

boxed.Method();

// Распаковка объекта (UnBoxing).
DemoStruct unBoxed = (DemoStruct)boxed;

void Increment(IXWrapper x) => x.X++;

var xw = new XWrapper();

Console.WriteLine(xw);

Increment(xw);

Console.WriteLine(xw);

Console.WriteLine("*****");

var ixw = xw as IXWrapper;
//var ixw = (IXWrapper)xw;

Console.WriteLine(ixw.X);
Increment(ixw);
Console.WriteLine(ixw.X);
Console.WriteLine(xw);


// Delay.
Console.ReadKey();


interface IInterface
{
    void Method();
}

struct DemoStruct : IInterface
{
    public void Method() => Console.WriteLine("Method");
}

interface IXWrapper
{
    int X { get; set; }
}

struct XWrapper : IXWrapper
{
    public XWrapper()
    {
    }

    public int X { get; set; } = 9;

    public override string ToString() => $"{X}";
}
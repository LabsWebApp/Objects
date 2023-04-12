using BenchmarkDotNet.Attributes;
using IoC;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IoCTest;

[MemoryDiagnoser]
public class IoCTests
{
    [GlobalSetup]
    public void Setup()
    {
        _lambdaIoC.Register<DemoClass>();
        _simpleIoC.Register<DemoClass>();
    }

    [Params(1, 10, 100, 1000)]
    public int N;

    private readonly SimpleIoC _simpleIoC = new();
    private readonly LambdaIoC _lambdaIoC = new();

    [Benchmark]
    public void LambdaIoCResolve()
    {
        for(var i  = 0; i < N; i++)
        {
            var obj = _lambdaIoC.Resolve<DemoClass>();
        }
    }

    [Benchmark]
    public void SimpleIoCResolve()
    {
        for (var i = 0; i < N; i++)
        {
            var obj = _simpleIoC.Resolve<DemoClass>();
        }
    }
}

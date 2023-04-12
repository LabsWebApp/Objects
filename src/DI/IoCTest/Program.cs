// Test Activator.CreateInstance(Type type, params object[] args)
using BenchmarkDotNet.Running;
using IoC;
using IoCTest;

BenchmarkRunner.Run<IoCTests>();

//var obj1 = Activator.CreateInstance(typeof(DemoClass));
//var obj2 = Activator.CreateInstance(typeof(DemoClass), 42);
//var obj3 = Activator.CreateInstance(typeof(DemoClass), "test");
//var obj4 = Activator.CreateInstance(typeof(DemoClass), 1, "test");

//Console.WriteLine();

//// Test LambdaIoC.CreateInstance(Type type, params object[] args)
//var ioc = new LambdaIoC();
//var obj5 = ioc.CreateInstance(typeof(DemoClass));
//var obj6 = ioc.CreateInstance(typeof(DemoClass), 42);
//var obj7 = ioc.CreateInstance(typeof(DemoClass), "test");
//var obj8 = ioc.CreateInstance(typeof(DemoClass), 1, "test");

Console.ReadKey();
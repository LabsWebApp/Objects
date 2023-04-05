// Nested classes.

var instance = new DemoClass.Nested();

instance.Method(666);

// Delay.
Console.ReadKey();


internal class DemoClass
{
    private static int _field = 0;

    public class Nested
    {
        public void Method(int a)
        {
            _field = a;

            Console.WriteLine(_field);
        }
    }
}
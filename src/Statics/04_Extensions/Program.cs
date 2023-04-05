// Расширяющие методы. (Extension methods)

// 1. Расширяющие методы могут быть только статическими и создаваться только в статических классах.
// 2. Аргумент расширения всегда должен быть только один и стоять первым в списке аргументов.
//    и должен быть помечен ключевым словом - this. 
// 3. Расширяющие методы не могут иметь опциональных параметров, но могут быть перегружены.
// 4. Использование ref и out аргументов. (Аргумент расширения не может быть out)

var text = "Тестовая строка";
     
// 1.
// Вызов метода, как статического.
ClassExtensions.ExtensionMethod1(text);

// Вызов метода, как расширяющего.
text.ExtensionMethod1();
"Тестовая строка".ExtensionMethod1();

// 2.
text = "Hello ";
Console.WriteLine();
text.ExtensionMethod2("world!");

// 3.
Console.WriteLine();
"Hello ".ExtensionMethod1("world!");
2.ExtensionMethod1();

// 4.
int summand1 = 1, summand2 = 2;/*, sum = 0;*/
Console.WriteLine();
summand1.Add(ref summand2, out var sum);
Console.WriteLine($"sum = {sum} (summand1 = {summand1}, summand2 = {summand2})");

// 5.
Console.WriteLine();
var date = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine(date.ToStr());
// Delay.
Console.ReadKey();


internal static class ClassExtensions
{
    // this - сообщает компилятору, что данный метод является расширяющим (Extension)!
    public static void ExtensionMethod1(this string value) => Console.WriteLine(value);

    public static void ExtensionMethod2(this string value1, string value2) => Console.WriteLine(value1 + value2);

    public static void ExtensionMethod1(this string value1, string value2) => ExtensionMethod2(value1, value2);

    public static void ExtensionMethod1(this int value) => ExtensionMethod1(value.ToString());

    public static void Add(this ref int summand1, ref int summand2, out int sum)
    {
        sum = summand1 + summand2;
        Console.WriteLine($"{summand1} + {summand2} = {sum}");
        summand1 = 0;
        summand2 = 0;
    }

    public static string ToStr(this DateOnly value)
    {
        Console.WriteLine("Сегодня: " + value.ToLongDateString());
        return value.ToString();
    }
}
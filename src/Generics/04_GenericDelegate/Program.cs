// Универсальные шаблоны. (Универсальный делегат)

static long Double(int i) => (long)i + i;

static string Concatenation(string s) => "Привет, " + s + "!";

var delegate1 = new Delegate<int, long>(Double);

var i = delegate1.Invoke(int.MaxValue);
Console.WriteLine(int.MaxValue);
Console.WriteLine(i);

var delegate2 = new Delegate<string, string>(Concatenation);
var s = delegate2("Alex");
Console.WriteLine(s);

Console.ReadKey();


// Создаем класс-делегата с именем  Delegate,
// параметризованный двумя Указателями Места Заполнения Типом - Т и R,
// метод который будет сообщен с экземпляром данного класса-делегата,
// будет принимать один аргумент, типа Указателя Места Заполнения Типом - Т,
// и возвращать значение типа Указателя Места Заполнения Типом - R.
delegate R Delegate<T, R>(T t);
//delegate TResult Delegate<TParam, TResult>(TParam t);
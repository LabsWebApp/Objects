// Ограничения на обобщения 
// ограничения - where
/*
 * Предложение where в универсальном определении задает ограничения на типы,
 * которые используются в качестве аргументов для параметров типа в универсальном типе,
 * методе, делегате или локальной функции.
 * Ограничения могут задавать интерфейсы, базовые классы или требовать,
 * чтобы универсальный тип был ссылочным типом, типом значения или неуправляемым типом.
 * Они объявляют возможности, которые должен иметь аргумент типа,
 * и должны размещаться после любого объявленного базового класса
 * или реализованных интерфейсов.
 */

namespace Where;

public class GenericClass<T> where T : IComparable<T>
{
    private T t;
    private bool LessThan(T p) => p.CompareTo(t) < 0;
}

/*
 * Некоторые типы не могут использоваться как ограничение базового класса:
 * Object, Array и ValueType. 
 */
public class UsingEnum<T> where T : System.Enum { }
public class UsingDelegate<T> where T : System.Delegate { }
public class Multicaster<T> where T : System.MulticastDelegate { }

//******
class MyClass<TClass, TStruct>
    where TClass : class
    where TStruct : struct
{ }

public abstract class B
{
    public void M<T>(T? item) where T : struct { }
    public abstract void M<T>(T? item);

}

//******
/*
 * Используйте ограничение default,
 * чтобы указать, что производный класс переопределяет метод без ограничения
 * в производном классе, или явную реализацию интерфейса.
 * Оно допустимо только для методов, переопределяющих базовые методы,
 * или явных реализаций интерфейса:
 */
public class D : B
{
    // Без ограничения "default" constraint, the compiler tries to override the first method in B
    public override void M<T>(T? item) where T : default { }
}

// NOTNULL 
class NotNullContainer<T> where T : notnull // NotNullContainer<int?>
{
}

/*
 * new (конструктор по умолчанию)
 * Ограничение new() отображается в предложении where последним.
 */
public class MyGenericClass<T> where T : IComparable<T>, new()
{
    private T _item = new T();
}

/*
 * Если параметров типа несколько, для каждого из них необходимо использовать
 * по одному предложению where, например:
 */
public interface IDemoInterface { }

class Dictionary<TKey, TValue>
    where TKey : IComparable<TKey>
    where TValue : IDemoInterface
{
    public void Add(TKey key, TValue value) { }
}
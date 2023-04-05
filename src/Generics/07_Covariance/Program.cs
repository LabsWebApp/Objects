// Ковариантность обобщений.
// Ковариантность позволяет использовать более конкретный тип, чем заданный изначально

var circle = new Circle();

IContainer<Shape> container = new Container<Circle>(circle);
//IContainer<Circle> container = new Container<Circle>(circle);


Console.WriteLine(container);

Console.ReadKey();


public abstract class Shape { }
public class Circle : Shape { }

public interface IContainer<out T>
{
    T Figure { get; }
}

public class Container<T> : IContainer<T>
{
    private T _figure;

    public Container(T figure) => this._figure = figure;

    public T Figure
    {
        get => _figure;
        set => _figure = value;
    }

    public override string ToString() => _figure!.GetType().ToString();
}
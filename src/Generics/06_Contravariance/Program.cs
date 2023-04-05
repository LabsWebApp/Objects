// Контравариантность обобщений.
// Контравариантность позволяет использовать более универсальный тип, чем заданный изначально

var circle = new Circle();
var point = new Point();

IContainer<Circle> container = new Container<Shape>(point);
//IContainer<Circle> container = new Container<Circle>(circle);

Console.WriteLine(container);

Console.ReadKey();


public abstract class Shape { }
public class Circle : Shape { }
public class Point : Shape { }

public interface IContainer<in T> //where T : Shape
{
    T Figure { set; }
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

    public override string? ToString() => _figure?.GetType().ToString();
}
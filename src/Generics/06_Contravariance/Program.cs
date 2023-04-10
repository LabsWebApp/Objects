// Контравариантность обобщений.
// Контравариантность позволяет использовать более универсальный тип, чем заданный изначально

<<<<<<< HEAD
//var circle = new Circle();
using Contravariance;

=======
var circle = new Circle();
>>>>>>> 36b5a2ccfc23e472b5d3f7b0f02d5b0994c47eff
var point = new Point();

IContainer<Circle> container = new Container<Shape>(point);
//IContainer<Circle> container = new Container<Circle>(circle);

Console.WriteLine(container);

Console.ReadKey();

<<<<<<< HEAD
namespace Contravariance
{
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
}
=======

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
>>>>>>> 36b5a2ccfc23e472b5d3f7b0f02d5b0994c47eff

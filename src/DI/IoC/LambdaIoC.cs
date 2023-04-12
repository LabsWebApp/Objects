using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace IoC;

public class LambdaIoC : SimpleIoC
{
    private readonly ConcurrentDictionary<Type, Func<object[], object>> _factories = new();

    public override object CreateInstance(Type type, params object[] args)
    {
        if (_factories.TryGetValue(type, out var factory)) 
            return factory(args);

        factory = CreateFactory(type);
        _factories.TryAdd(type, factory);

        return factory(args);
    }

    private static Func<object[], object> CreateFactory(Type type)
    {
        var constructor = type.GetConstructor(Type.EmptyTypes) ??
                          type.GetConstructors()
                              .MaxBy(c => c.GetParameters().Length)
                          ?? throw new MissingMethodException($"No constructor found for type '{type.FullName}'.");

        var argParams = Expression.Parameter(typeof(object[]), "args");
        var constructorParams = constructor.GetParameters();
        var paramExpressions = new Expression[constructorParams.Length];

        for (var i = 0; i < constructorParams.Length; i++)
        {
            var paramType = constructorParams[i].ParameterType;

            paramExpressions[i] = Expression.Convert(
                Expression.ArrayIndex(argParams, Expression.Constant(i)),
                paramType);
        }
        var constructorExpression = Expression.New(constructor, paramExpressions);
        var lambda = Expression.Lambda<Func<object[], object>>(
            constructorExpression, argParams);

        return lambda.Compile();
    }
}

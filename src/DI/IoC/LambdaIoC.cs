using System.Linq.Expressions;
using System.Reflection;

namespace IoC;

public class LambdaIoC : SimpleIoC
{
    protected override object CreateInstance(Type type, params object[] args)
    {
        var constructor = type.GetConstructor(args.Select(a => a.GetType()).ToArray())
                          ?? type.GetConstructor(Type.EmptyTypes)
                          ?? throw new MissingMethodException($"No constructor found for type '{type.FullName}' with specified arguments.");

        var paramExpressions = new Expression[args.Length];
        for (var i = 0; i < args.Length; i++) 
            paramExpressions[i] = Expression.Constant(args[i]);

        var constructorExpression = Expression.New(constructor, paramExpressions);
        var lambda = Expression.Lambda<Func<object>>(
            Expression.Convert(constructorExpression, typeof(object)));
        var instance = lambda.Compile().DynamicInvoke();
        return instance;
    }

}
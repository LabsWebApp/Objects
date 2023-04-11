namespace IoC;

public class SimpleIoC
{
    #region public methods

    public SimpleIoC() => RegisterInstance(this);

    public void Register<TType>() where TType : class =>
        Register<TType, TType>(false, null);

    public void Register<TType, TLive>() where TLive : class, TType => 
        Register<TType, TLive>(false, null);

    public void RegisterSingleton<TType>() where TType : class => 
        RegisterSingleton<TType, TType>();

    public void RegisterSingleton<TType, TLive>() where TLive : class, TType => 
        Register<TType, TLive>(true, null);

    public void RegisterInstance<TType>(TType instance) where TType : class => 
        RegisterInstance<TType, TType>(instance);

    public void RegisterInstance<TType, TLive>(TLive instance) where TLive : class, TType => 
        Register<TType, TLive>(true, instance);

    public TResolve Resolve<TResolve>() => (TResolve)ResolveObject(typeof(TResolve));

    public object Resolve(Type type) => ResolveObject(type);

    #endregion public methods

    #region private methods
    private void Register<TType, TLive>(bool isSingleton, TLive instance)
    {
        var type = typeof(TType);
        if (_registeredObjects.ContainsKey(type)) _registeredObjects.Remove(type);
        _registeredObjects.Add(type, new EnteredObject(typeof(TLive), isSingleton, instance));
    }
    private object ResolveObject(Type type)
    {
        var registeredObject = _registeredObjects[type];
        return registeredObject == null
            ? throw new ArgumentOutOfRangeException(
                $"The type {type.Name} has not been registered")
            : GetInstance(registeredObject);
    }
    private object GetInstance(EnteredObject registeredObject)
    {
        var instance = registeredObject.SingletonInstance;
        if (instance != null) return instance;
        var parameters = ResolveConstructorParameters(registeredObject);
        instance = registeredObject.CreateInstance(parameters.ToArray());
        return instance;
    }
    private IEnumerable<object> ResolveConstructorParameters(EnteredObject registeredObject)
    {
        var constructorInfo = registeredObject.LiveType.GetConstructors().First();
        return constructorInfo.GetParameters().Select(parameter => ResolveObject(parameter.ParameterType));
    }

    private class EnteredObject
    {
        private readonly bool _isSingleton;
        public EnteredObject(Type liveType, bool isSingleton, object instance)
        {
            _isSingleton = isSingleton;
            LiveType = liveType;
            SingletonInstance = instance;
        }
        public Type LiveType { get; }
        public object SingletonInstance { get; private set; }

        public object CreateInstance(params object[] args)
        {
            var instance = Activator.CreateInstance(LiveType, args);
            if (_isSingleton)
                SingletonInstance = instance;
            return instance;
        }
    }
    #endregion private methods

    #region MyRegion
    private readonly IDictionary<Type, EnteredObject> _registeredObjects = new Dictionary<Type, EnteredObject>();
    #endregion
}
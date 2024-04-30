namespace WF_WPF_13._MVP_Example__multi_window_.Services;

public class ServiceLocator
{
    // Singleton
    private static ServiceLocator? _instance;
    public static ServiceLocator? Instance = _instance ??= new ServiceLocator();

    private ServiceLocator() {
        _dependencies = new();
    }
    private Dictionary<Type, Func<object>> _dependencies;

    public T? Get<T>() where T : class
    {
        if(!_dependencies.TryGetValue(typeof(T), out var factory))
        {
            throw new KeyNotFoundException();
        }
        return (T?)factory.Invoke();
    }
    public ServiceLocator Add<T>(Func<T> factory) where T : class
    {
        ArgumentNullException.ThrowIfNull(factory);
        if (_dependencies.ContainsKey(typeof(T)))
        {
            throw new InvalidOperationException();
        }
        _dependencies.Add(typeof(T), factory);
        return this;
    }
}

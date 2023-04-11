namespace Di;

internal class NullLogger : ILogger
{
    public void WriteLine(string message)
    {
        // Ничего не делаем в этой реализации
    }
}
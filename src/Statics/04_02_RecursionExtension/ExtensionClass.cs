namespace RecursionExtension;

internal static class ExtensionClass
{
    public static void ExtensionMethod(this string value, int counter)
    {
        if (counter <= 0) 
            throw new ArgumentException("Счётчик должен быть больше 0.", nameof(counter));
        
        Console.WriteLine("Start: " + value + --counter);

        if (counter != 0) value.ExtensionMethod(counter);

        Console.WriteLine("Finish: " + value + counter);
    }
}
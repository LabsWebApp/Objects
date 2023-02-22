namespace Classes;

internal class Program
{
    // Поле только для чтения (устанавливается только конструктором)!
    public readonly string Field = "hello";

    // Конструктор.
    public Program()
    {
        Field = "Поле только для чтения";

        Field += "!";
    }

    private static void Main()
    {
        // Самоассоциация (self-association).
        Program program = new Program();

        Console.WriteLine(program.Field);

        // Ошибка Компиляции.
        //program.field = "Попытка записи в поле только для чтения.";

        // Delay.
        Console.ReadKey();
    }
}
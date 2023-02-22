namespace Classes.Document.Parts;

internal class Footer
{
    private string? _content;

    public string Content
    {
        private get => _content ?? "Нижний колонтитул отсутствует.";
        set => _content = value;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
namespace Classes.Document.Parts;

internal class Title
{
    private string? _content;

    public string Content
    {
        private get => _content ?? "Заголовок отсутствует.";
        set => _content = value;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
namespace Classes.Document.Parts;

internal class Body
{
    private string? _content;

    public string Content
    {
        private get => _content ?? "Тело документа отсутствует.";
        set => _content = value;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
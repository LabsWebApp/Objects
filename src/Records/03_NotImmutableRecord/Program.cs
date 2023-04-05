var desc = new Description();
Console.WriteLine(desc);
//desc.Title = "Exception";
desc.Text = "test";

Console.WriteLine(desc);
desc = desc with { Text = "new text" };
Console.WriteLine(desc);

Console.WriteLine(desc == desc with { Text = "new text" });
Console.WriteLine(desc with { Text = "rewritten text" });
Console.WriteLine(desc == desc with { Text = "rewritten text" });
Console.WriteLine(desc with { Text = "rewritten text".ToLower() } 
                  == desc with { Text = "rewritten text" });

Console.ReadLine();


internal record Description(int Id, string Title)
{
    public Description() : this(1, "new") => _text = "default";

    private string? _text;
    public string? Text
    {
        get => _text ?? "[the description is not set]"; 
        set => _text = value;
    }
}
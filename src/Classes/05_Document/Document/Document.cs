using Classes.Document.Parts;

namespace Classes.Document;

internal class Document
{
    // Поля
    private Title _title;
    private Body _body = null!;
    private Footer _footer = null!;

    private void InitializeDocument()
    {
        this._title = new Title();
        this._body = new Body();
        this._footer = new Footer();
    }

    public string Body
    {
        set => _body.Content = value;
    }

    public string Footer
    {
        set => _footer.Content = value;
    }

    public Document(string title)
    {
        InitializeDocument();
        this._title!.Content = title;
    }

    public void Show()
    {
        this._title.Show();
        this._body.Show();
        this._footer.Show();
    }
}
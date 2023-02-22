// Автоматически реализуемые свойства это более лаконичная форма свойств, их есть смысл использовать,
// когда в методах доступа (get и set) не требуется дополнительная логика. 
// При создании автоматически реализуемых свойств, компилятор создаст закрытое, анонимное резервное поле, 
// которое будет доступно с помощью методов get и set свойства.

Author author1 = new Author()
{
    Name = "Jeffrey Richter",            // Блок инициализатора.
    Book = "CLR via C#"
};

Author author2 = new Author       
{
    Name = "Steve McConnell",            // Блок инициализатора.
    Book = "Code Complete"
};

Console.WriteLine($"Name: {author1.Name}, Book: {author1.Book}");
Console.WriteLine($"Name: {author2.Name}, Book: {author2.Book}");

// Delay.
Console.ReadKey();

public class Author
{
    // Автоматически реализуемые свойства.
    public string Nick { get; } = "Nick";
    public string Name { get; init; }
    public string Book { get; set; }
}
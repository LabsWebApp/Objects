using System.Threading.Channels;
using Classes.Document;

Document document = new("Контракт");

document.Show();
Console.WriteLine();

document.Body = "Тело контракта...";
document.Footer = "Директор: Иванов И.И.";

document.Show();

// Delay.
Console.ReadKey();
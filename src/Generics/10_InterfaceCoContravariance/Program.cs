// Ковариантные интерфейсы

ICoMessenger<Message> outlook = new EmailMessenger();
Message message = outlook.WriteMessage("Hello World");
Console.WriteLine(message.Text);    // Email: Hello World

ICoMessenger<EmailMessage> emailClient = new EmailMessenger();
ICoMessenger<Message> messenger = emailClient;
Message emailMessage = messenger.WriteMessage("Hi!");
Console.WriteLine(emailMessage.Text);    // Email: Hi!

// Контравариантные интерфейсы

IContraMessenger<EmailMessage> outlook2 = new SimpleMessenger();
outlook2.SendMessage(new EmailMessage("Hi!"));

IContraMessenger<Message> telegram = new SimpleMessenger();
IContraMessenger<EmailMessage> emailClient2 = telegram;
emailClient2.SendMessage(new EmailMessage("Hello"));

Console.ReadKey();

class Message
{
    public string Text { get; set; }
    public Message(string text) => Text = text;
}
class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}

// Ковариантные интерфейс
interface ICoMessenger<out T>
{
    T WriteMessage(string text);
}
class EmailMessenger : ICoMessenger<EmailMessage>
{
    public EmailMessage WriteMessage(string text) => new($"Email: {text}");
}

// Контравариантные интерфейсы
interface IContraMessenger<in T>
{
    void SendMessage(T message);
}
class SimpleMessenger : IContraMessenger<Message>
{
    public void SendMessage(Message message) => Console.WriteLine($"Отправляется сообщение: {message.Text}");
}
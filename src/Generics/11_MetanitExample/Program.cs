using MetanitExample;

namespace MetanitGenerics;

internal delegate T MessageBuilder<out T>(string text);

internal delegate void MessageReceiver<in T>(T message);

internal delegate TResult MessageConverter<in TParam, out TResult>(TParam message);

internal delegate TResult FindSender<out TResult>();
internal delegate void Send<in T>(T param);

internal class Program
{
    static void Main()
    {
        // ковариантность
        EmailMessage WriteEmailMessage(string text) => new(text);

        MessageBuilder<EmailMessage> eMessageBuilder = WriteEmailMessage;

        MessageBuilder<Message> messageBuilder = eMessageBuilder;     // ковариантность
        var message = messageBuilder("hello Tom"); // вызов делегата
        message.Print(); // Email: hello Tom

        WriteLine("****");

        // контравариантность
        void ReceiveMessage(Message m) => m.Print();

        MessageReceiver<Message> messageReceiver = ReceiveMessage;

        MessageReceiver<EmailMessage> eMessageReceiver = messageReceiver; // контравариантность
        eMessageReceiver(new EmailMessage("Hello World!"));

        WriteLine("****");

        // MIX
        EmailMessage ConvertToEmail(Message m) => new(m.Text);

        MessageConverter<Message, EmailMessage> fConverter = ConvertToEmail;

        MessageConverter<SmsMessage, Message> converter = fConverter;

        var messageMix = converter(new SmsMessage("Delegates"));
        messageMix.Print();    // Email: Delegates


        ReadKey();



        // *********************
        var msg = new TextMsg("ПРИВЕТ");
        Send<TextMsg>? sendText;

        FindSender<Sender>? tool;
        FindSender<Computer> pc = Searcher.FindComputer;

        tool = pc;
        var sender = tool.Invoke();
        Send<ContextMsg> send = sender.Send;

        sendText = send;

        sendText.Invoke(msg);

        ReadKey();
    }
}
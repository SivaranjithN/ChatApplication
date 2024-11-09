namespace ChatAppMAUI.Model;

public class Message
{
    public string Text { get; set; }
    public string Sender { get; set; }
    public DateTime Timestamp { get; set; }

    public bool IsSentByUser { get; set; }

    public string ImageSource { get; set; }

    public string User { get; set; }
    public bool IsIncoming { get; set; }

    public Message(string text, string sender)
    {
        Text = text;
        Sender = sender;
        Timestamp = DateTime.Now;
    }
}
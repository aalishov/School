namespace MailClient
{
    public class Mail
    {
        public Mail(string sender, string receiver, string body)
        {
            Sender = sender;
            Receiver = receiver;
            Body = body;
        }

        public string Sender { get; private set; }

        public string Receiver { get; private set; }
        public string Body { get; private set; }
        public override string ToString()
        {
            return $"From: {Sender} / To: {Receiver}{Environment.NewLine}Message: {Body}";
        }
    }
}

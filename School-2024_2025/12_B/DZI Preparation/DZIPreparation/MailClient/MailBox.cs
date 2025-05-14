using System.Text;

namespace MailClient
{
    public class MailBox
    {
        private List<Mail> inbox;
        private List<Mail> archive;

        public MailBox(int capacity)
        {
            Capacity = capacity;
            inbox = new List<Mail>();
            archive = new List<Mail>();
        }

        public int Capacity { get; private set; }

        public void IncomingMail(Mail mail)
        {
            if (inbox.Count < Capacity)
            {
                inbox.Add(mail);
            }
        }
        public bool DeleteMail(string sender)
        {
            Mail mail = inbox.FirstOrDefault(x => x.Sender == sender);
            if (mail != null)
            {
                inbox.Remove(mail);
                return true;
            }
            return false;
        }
        public int ArchiveInboxMessages()
        {
            archive = inbox.ToList();
            inbox.Clear();
            int count = archive.Count;
            return count;
        }
        public string GetLongestMessage()
        {
            Mail mail = inbox.OrderByDescending(x=>x.Body).FirstOrDefault();
            return mail.ToString();
        }
        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (Mail mail in archive)
            {
                sb.AppendLine(mail.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}

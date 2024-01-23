using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MailBox
{
    private List<Mail> inbox = new List<Mail>();
    private List<Mail> archive = new List<Mail>();

    public MailBox(int capacity)
    {
        Capacity = capacity;
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
        Mail firstBySender = inbox.FirstOrDefault(x => x.Sender == sender);
        return inbox.Remove(firstBySender);
    }
    public int ArchiveInboxMessages()
    {
        archive.AddRange(inbox);
        int count = inbox.Count;
        inbox.Clear();
        return count;
    }
    public string GetLongestMessage()
    {
        //Mail mail = inbox.OrderBy(x => x.Body.Length).LastOrDefault();
        Mail mail = inbox.OrderByDescending(x => x.Body.Length).FirstOrDefault();


        return mail.ToString();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Inbox:");
        foreach (var m in inbox)
        {
            sb.AppendLine(m.ToString());
        }
        return sb.ToString();
    }
}


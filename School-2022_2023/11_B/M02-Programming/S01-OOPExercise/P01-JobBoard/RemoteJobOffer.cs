using System;
using System.Collections.Generic;
using System.Text;

public class RemoteJobOffer : JobOffer
{
    public RemoteJobOffer(string jobTitle, string company, double salary, bool fullyRemote) : base(jobTitle, company, salary)
    {
        this.FullyRemote = fullyRemote;
    }
    public bool FullyRemote { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        string remote = FullyRemote ? "yes" : "no"; ;
        sb.AppendLine($"Fully Remote: {remote}");
        return sb.ToString().TrimEnd();
    }
}


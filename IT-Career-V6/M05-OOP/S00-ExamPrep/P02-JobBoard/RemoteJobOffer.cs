using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class RemoteJobOffer : JobOffer
{
    public RemoteJobOffer(string jobTitle, string company, double salary, bool fullyRemote) : base(jobTitle, company, salary)
    {
        FullyRemote = fullyRemote;
    }

    public bool FullyRemote { get; set; }

    public override string ToString()
    {
        string fullyRemote = FullyRemote ? "yes" : "no";
        return base.ToString()+$"{Environment.NewLine}Fully Remote: {fullyRemote}";
    }
}


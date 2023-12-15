public class RemoteJobOffer : JobOffer
{
    public RemoteJobOffer(string jobTitle, string company, double salary, bool fullyRemote) : base(jobTitle, company, salary)
    {
        FullyRemote = fullyRemote;
    }
    public bool FullyRemote { get; set; }

    public override string ToString()
    {
        if (FullyRemote)
        {
            return base.ToString() + "\nFully Remote: yes";
        }
        return base.ToString() + "\nFully Remote: no";

    }
}


using System;

public class Program
{
    static void Main()
    {
        OnSiteJobOffer job = new OnSiteJobOffer("Mechanic", "Serviz", 2000, "Velingrad");
        RemoteJobOffer job2 = new RemoteJobOffer("Mechanic", "Serviz", 2000, false);
        Console.WriteLine(job2);
    }
}


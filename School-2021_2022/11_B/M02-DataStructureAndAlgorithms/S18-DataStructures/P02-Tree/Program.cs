using System;
public class Program
{
    static void Main()
    {
        Tree03();
    }

    static void Tree03()
    {
        Tree<string> t = new Tree<string>("50",
            new Tree<string>("L",
                new Tree<string>("^",
                    new Tree<string>("1"),
                    new Tree<string>("2"))));
        t.Print();
    }
}


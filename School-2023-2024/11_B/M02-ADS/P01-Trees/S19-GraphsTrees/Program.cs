using System;


public class Program
{
    public static void Main()
    {
        Tree<int> tree = Tree03();

        string result = tree.PrintS();
        Console.WriteLine(result);
    }
    private static Tree<int> Tree03()
    {
        return new Tree<int>
            (7,
            new Tree<int>(19, 
                new Tree<int>(1),
                new Tree<int>(12,
                    new Tree<int>(120,
                        new Tree<int>(121))),
                new Tree<int>(31)),
            new Tree<int>(21),
            new Tree<int>(14,
                new Tree<int>(23),
                new Tree<int>(6))
            );
    }

    private static Tree<int> Tree02()
    {
        return new Tree<int>
            (
                50,
                new Tree<int>(30),
                new Tree<int>(31,
                        new Tree<int>(40),
                        new Tree<int>(41,
                            new Tree<int>(30))
                    ),
                new Tree<int>(32)
            );
    }


    private static Tree<int> Tree01()
    {
        return new Tree<int>
             (
                 5,
                 new Tree<int>(15,
                     new Tree<int>(7),
                     new Tree<int>(8,
                         new Tree<int>(32))),
                 new Tree<int>(25),
                 new Tree<int>(35,
                     new Tree<int>(4),
                     new Tree<int>(16))
             );
    }
}

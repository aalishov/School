using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        Tree_02();
    }
    static void Tree_02()
    {
        Tree<string> tree = new Tree<string>
            (
                "50",
                new Tree<string>
                (
                    "L",
                    new Tree<string>
                    (
                        "^",
                        new Tree<string>("1"),
                        new Tree<string>("2")
                    ),
                    new Tree<string>("?")
                )
            );
        tree.Print();
        List<string> elements = tree.OrderDFS().ToList();
        Console.WriteLine("DFS =>" + string.Join(", ", elements));
    }
    static void Tree_01()
    {
        Tree<int> tree = new Tree<int>
            (
                50,
                new Tree<int>
                (
                    30
                )
            );
        tree.Print();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Trees
{
    public class Program
    {
        static void Main()
        {
            Tree4();
        }
        public static void Tree4()
        {
            Tree<string> tree = new Tree<string>(
                "50",
                    new Tree<string>("30"),
                    new Tree<string>("40"),
                    new Tree<string>("50"),
                    new Tree<string>("60")
                );
            Console.WriteLine(tree.PrintS());
            List<string> dfs = tree.OrderDFS().ToList();
            Console.WriteLine($"DFS = > {string.Join(" ", dfs)}");
            List<string> bfs = tree.OrderBFS().ToList();
            Console.WriteLine($"BFS = > {string.Join(" ", bfs)}");
        }

        public static void Tree3() 
        {
            Tree<string> tree = new Tree<string>(
                "50",
                    new Tree<string>("L",
                        new Tree<string>("^"))
                );
            Console.WriteLine(tree.PrintS());
            List<string> dfs = tree.OrderDFS().ToList();
            Console.WriteLine($"DFS = > {string.Join(" ", dfs)}");
            List<string> bfs = tree.OrderBFS().ToList();
            Console.WriteLine($"BFS = > {string.Join(" ", bfs)}");
        }

        public static void Tree2()
        {
            Tree<int> tree = new Tree<int>
                (
                    50,
                        new Tree<int>(30),
                        new Tree<int>(8,
                           new Tree<int>(15,
                                new Tree<int>(16,
                                    new Tree<int>(66)
                                    ),
                                new Tree<int>(17,
                                    new Tree<int>(77,
                                        new Tree<int>(79)))
                                ),
                           new Tree<int>(25),
                           new Tree<int>(35)
                           ),
                        new Tree<int>(16)
                );
            Console.WriteLine(tree.PrintS());
            List<int> dfs = tree.OrderDFS().ToList();
            Console.WriteLine($"DFS = > {string.Join(" ",dfs)}");
            List<int> bfs = tree.OrderBFS().ToList();
            Console.WriteLine($"BFS = > {string.Join(" ", bfs)}");
        }

        public static void Tree1()
        {
            Tree<int> tree = new Tree<int>
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

            string result = tree.PrintS();
            Console.WriteLine(result);
        }
    }
}

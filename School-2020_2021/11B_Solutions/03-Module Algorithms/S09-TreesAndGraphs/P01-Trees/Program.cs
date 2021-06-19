using System;

namespace P01_Trees
{
    class Program
    {
        static void Main()
        {
            PrintTree_6();
        }
        public static void PrintTree_6()
        {
            Tree<int> tree = new Tree<int>(50,
                new Tree<int>(30, 
                    new Tree<int>(15),
                    new Tree<int>(25)),
                new Tree<int>(40),
                new Tree<int>(50),
                new Tree<int>(60));

            Console.WriteLine($"BFS - {string.Join(", ", tree.OrderBFS())}");
            Console.WriteLine($"DFS - {string.Join(", ", tree.OrderDFS())}");
            Console.WriteLine(tree.PrintS());
        }

        public static void PrintTreee_5()
        {
            Tree<string> tree = new Tree<string>("50",
                new Tree<string>("L",
                    new Tree<string>("^",
                        new Tree<string>("1"),
                        new Tree<string>("2"))));
            Console.WriteLine(tree.PrintS());
        }

        public static void PrintTree_4()
        {
            Tree<string> tree = new Tree<string>("50",
                new Tree<string>("L",
                    new Tree<string>("^")));
            Console.WriteLine(tree.PrintS());
        }

        public static void PrintTree_3()
        {
            Tree<int> tree = new Tree<int>(50,
                new Tree<int>(30));
            Console.WriteLine(tree.PrintS());
        }

        public static void PrintTree_2()
        {
            // Създаване на дървовидна структура
            Tree<int> tree = new Tree<int>
            (
                7,
                new Tree<int>
                (
                    19,
                    new Tree<int>(1),
                    new Tree<int>(12),
                    new Tree<int>(31)
                ),
                new Tree<int>(21),
                new Tree<int>
                (
                    14,
                    new Tree<int>(23),
                    new Tree<int>(6)
                )
            );

            // Отпечатване на вървото
            Console.WriteLine(tree.PrintS());

            // Ред на посещаване на възлите от дървото
            var ordereDFS = tree.OrderDFS();
            Console.WriteLine("DFS: {0}", string.Join(" ", ordereDFS));

            // Ред на посещение на възлите
            var orderBFS = tree.OrderBFS();
            Console.WriteLine("BFS: {0}", string.Join(" ", orderBFS));
        }
        public static void PrintTree_1()
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
            Console.WriteLine(tree.PrintS());
        }
    }
}

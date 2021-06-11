using System;

namespace P01_Trees
{
    class Program
    {
        static void Main()
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

            //// Създаване на дървовидна структура
            //Tree<int> tree = new Tree<int>
            //(
            //    7,
            //    new Tree<int>
            //    (
            //        19,
            //        new Tree<int>(1),
            //        new Tree<int>(12),
            //        new Tree<int>(31)
            //    ),
            //    new Tree<int>(21),
            //    new Tree<int>
            //    (
            //        14,
            //        new Tree<int>(23),
            //        new Tree<int>(6)
            //    )
            //);

            //// Отпечатване на вървото
            //Console.WriteLine(tree.PrintS());

            //// Ред на посещаване на възлите от дървото
            //var ordereDFS = tree.OrderDFS();
            //Console.WriteLine("DFS: {0}", string.Join(" ", ordereDFS));

            //// Ред на посещение на възлите
            //var orderBFS = tree.OrderBFS();
            //Console.WriteLine("BFS: {0}", string.Join(" ", orderBFS));
        }
    }
}

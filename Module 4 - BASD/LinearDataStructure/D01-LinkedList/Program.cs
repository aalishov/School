

namespace D01_LinkedList
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            //Речник
            SortedDictionary<int, string> sortedNumber = new SortedDictionary<int, string>();

            //Масив
            int[] numsArr = new int[5] { 7, -15, 31, 65, 12 };

            //Списък
            List<int> listNums = new List<int>();

            listNums.Add(12);
            //Console.WriteLine(listNums[0]) ;
            listNums[0] = 12;
            listNums.Remove(12);

            LinkedList<int> linkedListNums = new LinkedList<int>(numsArr);
            PrintLinkdList("Old linked list", linkedListNums);
            linkedListNums.AddFirst(-99);
            PrintLinkdList("Add first, linked list", linkedListNums);
            linkedListNums.AddLast(-88);
            PrintLinkdList("Add last, linked list", linkedListNums);
            linkedListNums.AddAfter(linkedListNums.Find(-99), 0);
            PrintLinkdList("Add after, linked list", linkedListNums);
            linkedListNums.AddBefore(linkedListNums.Find(31), 0);
            PrintLinkdList("Add before, linked list", linkedListNums);

            Console.WriteLine($"First: {linkedListNums.First.Value}");
            Console.WriteLine($"Last: {linkedListNums.Last.Value}");
            Console.WriteLine($"Last.Previous: {linkedListNums.Last.Previous.Previous.Value}");
            //Console.WriteLine($"Last.Next: {linkedListNums.Last.Next.Value}");

            if (linkedListNums.Contains(0))
            {
                Console.WriteLine($"Find: {linkedListNums.Find(0).Previous.Value}");
            }
            else
            {
                Console.WriteLine($"Element not exist!");
            }

            Console.WriteLine($"Find: {linkedListNums.Find(0).Next.Value}");
        }

        private static void PrintLinkdList(string text, LinkedList<int> linkedListNums)
        {
            Console.WriteLine($"{text}: {string.Join(", ", linkedListNums)}");
        }
    }
}

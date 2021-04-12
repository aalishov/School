using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Array
        int[] numArray = new int[5];
        numArray[0] = 15;
        numArray[4] = 9;
        Console.WriteLine($"Array: {string.Join(", ",numArray)}");

        //List
        List<int> numList = new List<int>();
        numList.Add(5);
        numList[0] = 19;
        numList.Add(15);
        numList.Insert(0, 8);
        Console.WriteLine($"List: {string.Join(", ", numList)}");

        //HashSet
        HashSet<int> numHashSet = new HashSet<int>();
        numHashSet.Add(15);
        numHashSet.Add(15);
        numHashSet.Add(19);
        numHashSet.Add(7);
        numHashSet.Add(15);
        Console.WriteLine($"Hashset: {string.Join(", ", numHashSet)}");

        //Dictionary
        SortedDictionary<string, HashSet<string>> phoneBook = new SortedDictionary<string, HashSet<string>>();
        phoneBook.Add("Ivan", new HashSet<string>() { "+359 555 1236", "+359 555 1237" });
        phoneBook.Add("Pesho", new HashSet<string>() { "+359 555 1238", "+359 555 1239", "+359 555 1239", "+359 555 6239" });
        phoneBook.Add("Alex", new HashSet<string>() { "+359 555 1569", "+359 555 4589", "+359 555 7845", "+359 555 7845" });

        Console.WriteLine("Dictionary/SortedDictionary");
        foreach (var entry in phoneBook)
        {
            Console.WriteLine($"\t{entry.Key} => {string.Join(", ", entry.Value)}");
        }
    }
}


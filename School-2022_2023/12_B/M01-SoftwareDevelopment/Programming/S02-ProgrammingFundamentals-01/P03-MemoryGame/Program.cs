using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<string> elements = Console.ReadLine().Split(" ").ToList();
        int count = 0;
        string input = String.Empty;
        while ((input = Console.ReadLine()) != "end")
        {
            int[] indexes = input.Split(" ").Select(int.Parse).OrderByDescending(x => x).ToArray();
            count++;

            if (indexes.Any(x => x < 0 || x >= elements.Count) || indexes[0] == indexes[1])
            {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                int index = elements.Count / 2;
                elements.Insert(index, $"-{count}a");
                elements.Insert(index++, $"-{count}a");
            }
            else
            {
                if (elements[indexes[0]] == elements[indexes[1]])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[indexes[0]]}!");
                    elements.RemoveAt(indexes[0]);
                    elements.RemoveAt(indexes[1]);
                }
                else{Console.WriteLine("Try again!");}
            }
            if (!elements.Any())
            {
                Console.WriteLine($"You have won in {count--} turns!");
                break;
            }
        }
        if (elements.Any())
        {
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", elements));
        }
    }
}


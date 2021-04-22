using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        Queue<string> players = new Queue<string>(Console.ReadLine().Split(' ').ToList());
        int n = int.Parse(Console.ReadLine());

        int i = 1;
        while (players.Count > 1)
        {
            string current = players.Dequeue();
            if (i == n)
            {
                Console.WriteLine($"Removed {current}");
                i = 1;
            }
            else
            {
                i++;
                players.Enqueue(current);
            }
        }
        Console.WriteLine($"Last is {players.Dequeue()}");
    }
}



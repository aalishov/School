using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

        Queue<string> queue = new Queue<string>();

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "End")
        {
            if (input == "Paid")
            {
                while (queue.Count > 0)
                {
                    string client = queue.Dequeue();
                    Console.WriteLine(client);
                }
            }
            else
            {
                queue.Enqueue(input);
            }
        }
        Console.WriteLine($"{queue.Count} people remaining");
    }
}


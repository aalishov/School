using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Queue<string> clients = new Queue<string>();

        while (true)
        {
            string name = Console.ReadLine();
            if (name=="End")
            {
                Console.WriteLine($"{clients.Count} people remaining.");
                break;
            }
            else if (name=="Paid")
            {
                while (clients.Any())
                {
                    Console.WriteLine($"Pay: {clients.Dequeue()}");
                }
            }
            else
            {
                clients.Enqueue(name);
            }
        }
    }
}


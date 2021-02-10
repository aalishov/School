using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        while (true)
        {
            string[] info = Console.ReadLine().Split(' ').ToArray();

            string cmd = info[0];

            if (cmd == "END")
            {
                break;
            }
            else if (cmd == "A")
            {
                string name = info[1];
                string number = info[2];
                if (phoneBook.ContainsKey(name))
                {
                    phoneBook[name] = number;
                }
                else
                {
                    phoneBook.Add(name, number);
                }
            }
            else if (cmd == "S")
            {
                string name = info[1];
                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phoneBook[name]} ");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }
        }
    }
}


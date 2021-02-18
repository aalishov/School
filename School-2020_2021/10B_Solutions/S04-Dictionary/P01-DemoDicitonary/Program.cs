using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        phoneBook.Add("Ivan", "+3598888");
        phoneBook.Add("Gosho", "454545");

        while (true)
        {
            Console.Write("Enter command: ");
            string cmd = Console.ReadLine();

            switch (cmd)
            {
                case "Add":
                    AddEntry(phoneBook);
                    break;
                case "Remove":
                     RemoveEntry(phoneBook);
                    break;
                case "Call":
                    Calling(phoneBook);
                    break;
                case "Print":
                    foreach (var name in phoneBook)
                    {
                        Console.WriteLine($"{ name.Key} => {name.Value}");
                    }
                    break;
            }
        }
    }

    private static void Calling(Dictionary<string, string> phoneBook)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine($"Calling {phoneBook[name]}");
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }

    private static void RemoveEntry(Dictionary<string, string> phoneBook)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        if (phoneBook.ContainsKey(name))
        {
            phoneBook.Remove(name);
            Console.WriteLine("Removed");
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }

    private static void AddEntry(Dictionary<string, string> phoneBook)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter phone: ");
        string phone = Console.ReadLine();
        if (phoneBook.ContainsKey(name))
        {
            phoneBook[name] = phone;
        }
        else
        {
            phoneBook.Add(name, phone);
        }
    }
}


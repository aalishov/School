using System;


public class Program
{
    public static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        while (true)
        {
            string[] cmd = Console.ReadLine().Split(" ");
            if (cmd[0] == "end") { break; }
            else if (cmd[0] == "A")
            {
                string name = cmd[1];
                string phone = cmd[2];
                if (phoneBook.ContainsKey(name)) { phoneBook[name] = phone; }
                else { phoneBook.Add(name, phone); }
            }
            else if (cmd[0]=="S")
            {
                string name = cmd[1];
                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phoneBook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }
        }
    }
}

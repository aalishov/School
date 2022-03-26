using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(", ");
        Queue<string> songs = new Queue<string>(input);

        while (songs.Count > 0)
        {
            string[] cmd = Console.ReadLine().Split(' ');
            switch (cmd[0].ToLower())
            {
                case "play":
                    songs.Dequeue();
                    break;
                case "add":
                    string song = string.Join(" ", cmd.Skip(1));
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                    break;
                case "show":
                    Console.WriteLine(string.Join(", ", songs));
                    break;
            }
        }
        Console.WriteLine("No more songs");
    }
}


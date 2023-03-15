using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string[] songs = Console.ReadLine().Split(", ");
        Queue<string> playlist = new Queue<string>(songs);

        while (playlist.Count > 0)
        {
            string[] info = Console.ReadLine().Split(' ');
            switch (info[0])
            {
                case "Play":
                    playlist.Dequeue();
                    if (playlist.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        Environment.Exit(0);
                    }
                    break;
                case "Add":
                    string song = string.Join(" ", info.Skip(1));
                    if (playlist.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        playlist.Enqueue(song);
                    }
                    break;
                case "Show":
                    Console.WriteLine(string.Join(", ", playlist));
                    break;
            }
        }
    }
}


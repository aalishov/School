namespace Ex04_P06_SongsQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            Queue<string> playList = new Queue<string>(Console.ReadLine().Split(", ").ToArray());

            while (playList.Any())
            {
                string[] input = Console.ReadLine().Split();

                string cmd = input[0];

                switch (cmd)
                {
                    case "Play":
                        playList.Dequeue();
                        break;
                    case "Add":
                        string songName = string.Join(" ", input.Skip(1));
                        if (!playList.Contains(songName))
                        {
                            playList.Enqueue(songName);
                        }
                        else
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",playList));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}

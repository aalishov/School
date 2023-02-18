using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> wagons = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        int max = int.Parse(Console.ReadLine());

        while (true)
        {
            string[] info = Console.ReadLine().Split(" ");

            if (info[0].ToLower() == "add")
            {
                int people = int.Parse(info[1]);
                wagons.Add(people);
            }
            else if (info[0].ToLower() == "end")
            {
                Console.WriteLine(string.Join(", ",wagons));
                break;
            }
            else
            {
                int people = int.Parse(info[0]);

                for (int i = 0; i < wagons.Count; i++)
                {
                    if (wagons[i] + people <= max)
                    {
                        wagons[i] += people;
                        break;
                    }
                }
            }
        }
    }
}


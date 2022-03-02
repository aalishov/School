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
            string cmd = Console.ReadLine();//30
            if (cmd == "end")
            {
                break;
            }
            List<string> info = cmd.Split(' ').ToList();
            //[30]
            if (info.Contains("Add"))
            {
                wagons.Add(int.Parse(info[1]));
            }
            else
            {
                int passengers = int.Parse(info[0]);
                //32 54 21 12 4 0 23 10 0
                for (int i = 0; i < wagons.Count; i++)
                {
                    if (passengers + wagons[i] <= max)
                    {
                        wagons[i] += passengers;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(string.Join(" ", wagons));
    }
}


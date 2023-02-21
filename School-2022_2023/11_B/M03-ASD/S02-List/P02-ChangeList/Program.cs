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

        int max = 100;

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
                Console.WriteLine(string.Join(", ", wagons));
                break;
            }
            else if (info[0].ToLower() == "delete")
            {
                int deleteNum = int.Parse(info[1]);
                while (wagons.Contains(deleteNum))
                {
                    wagons.Remove(deleteNum);
                }
            }
            else if (info[0].ToLower()=="insert")
            {
                int element = int.Parse(info[1]);
                int position = int.Parse(info[2]);
                if (wagons.Count-1<position || position<0)
                {
                    Console.WriteLine("Invalid index!");
                }
                else
                {
                    wagons.Insert(position, element);
                }
                
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
            Console.WriteLine(string.Join(", ", wagons));
        }
    }
}


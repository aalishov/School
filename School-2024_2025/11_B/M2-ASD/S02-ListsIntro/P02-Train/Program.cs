namespace P02_Train
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(long.MaxValue);
            List<int> wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int max = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (input[0] == "end")
                {
                    break;
                }
                else if (input[0] == "Add")
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    int people = int.Parse(input[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int freeSpace = max - wagons[i];
                        if (freeSpace >= people) 
                        {
                            wagons[i] += people; 
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}

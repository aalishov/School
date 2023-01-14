using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        for (int i = 0; i < wagons.Count; i++)
        {
            int spaces = (4 - wagons[i]);
            if (people < 0){ break;}
            if (people >= spaces)
            {
                people -= spaces;
                wagons[i] += spaces;
            }
            else
            {
                wagons[i] += people;
                people = 0;
            }
        }
        if (people > 0)
        {
            Console.WriteLine($"There isn't enough space! {people} people in a queue!");
        }
        else if (wagons.Any(x=>x!=4))
        {
            Console.WriteLine("The lift has empty spots!");
        }        
        Console.WriteLine(String.Join(" ", wagons));
    }
}


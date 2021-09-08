using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static Stack<int> males;
    private static Queue<int> females;
    static int matches = 0;

    static void Main()
    {
        //Вход
        Input();

        Action();

        //Изход
        Output();
    }

    private static void Input()
    {
        males = new Stack<int>(ReadArr());
        females = new Queue<int>(ReadArr());
    }

    private static void Output()
    {
        Console.WriteLine($"Matches: {matches}");

        string malesResult = males.Any() ? $"{string.Join(", ", males)}" : "none";
        string femalesResult = females.Any() ? $"{string.Join(", ", females)}" : "none";

        Console.WriteLine($"Males left: {malesResult}");
        Console.WriteLine($"Females left: {femalesResult}");
    }

    private static void Action()
    {
        while (males.Any() && females.Any())
        {
            int male = males.Peek();
            if (male <= 0)
            {
                males.Pop();
                continue;
            }
            if (male % 25 == 0)
            {
                males.Pop();
                if (males.Any())
                {
                    males.Pop();
                }
                continue;
            }

            int female = females.Peek();
            if (female <= 0)
            {
                females.Dequeue();
                continue;
            }
            if (female % 25 == 0)
            {
                females.Dequeue();
                if (females.Any())
                {
                    females.Dequeue();
                }
                continue;
            }

            males.Pop();
            females.Dequeue();

            if (male == female) { matches++; }
            else { males.Push(male -= 2); }
        }
    }

    private static int[] ReadArr()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }
}


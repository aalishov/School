using System;

public class Program
{
    static void Main()
    {
        decimal capacity = decimal.Parse(Console.ReadLine());
        string input = null;

        int counter = 0;
        bool hasSpace = true;

        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            decimal volume = decimal.Parse(input);
            counter++;
            if (counter % 3 == 0) { volume *= 1.1m; }
            if (capacity >= volume) { capacity -= volume; }
            else { hasSpace = false; break; }
        }
        if (hasSpace)
        {
            Console.WriteLine("Congratulations! All suitcases are loaded!");
        }
        else
        {
            counter--;
            Console.WriteLine("No more space!");
        }
        Console.WriteLine($"Statistic: {counter} suitcases loaded.");
    }
}


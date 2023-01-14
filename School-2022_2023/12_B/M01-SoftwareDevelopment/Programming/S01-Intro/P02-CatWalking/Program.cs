using System;

public class Program
{
    static void Main()
    {
        const int CaloriesPerMinute = 5;

        int minutes = int.Parse(Console.ReadLine());
        int walks = int.Parse(Console.ReadLine());
        int calories = int.Parse(Console.ReadLine());

        int total = minutes * walks * CaloriesPerMinute;
        if (calories / 2 > total)
        {
            Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {total}.");
        }
        else
        {
            Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {total}.");
        }
    }
}


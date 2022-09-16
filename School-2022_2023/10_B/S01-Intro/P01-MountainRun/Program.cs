using System;

public class Program
{
    static void Main()
    {
        double record = double.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        double seconds = double.Parse(Console.ReadLine());

        double total = distance * seconds + Math.Floor(distance / 50) * 30;

        if (total < record)
        {
            Console.WriteLine($"Yes! The new record is {total:f2} seconds.");
        }
        else
        {
            Console.WriteLine($"No! He was {total-record:f2} seconds slower.");
        }
    }
}


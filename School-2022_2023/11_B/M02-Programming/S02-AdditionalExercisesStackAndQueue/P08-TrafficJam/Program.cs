using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int carCount = int.Parse(Console.ReadLine());
        int carsPassedCount = 0;
        Queue<string> cars = new Queue<string>();
        string input = null;
        while ((input=Console.ReadLine())!="end") 
        {
            if (input=="green")
            {
                for (int i = 0; i < carCount; i++)
                {
                    if (cars.Count > 0)
                    {
                        carsPassedCount++;
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                    }
                    else { break; }
                }
            }
            else { cars.Enqueue(input); }
            
        }
        Console.WriteLine($"{carsPassedCount} cars passed the crossroads.");
    }
}


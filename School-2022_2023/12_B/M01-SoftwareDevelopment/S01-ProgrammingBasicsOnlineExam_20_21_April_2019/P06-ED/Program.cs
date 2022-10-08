using System;

public class Program
{
    static void Main()
    {
        double cost = 0;
        double totalCost = 0;
        int counter = 0;
        int customers = int.Parse(Console.ReadLine());
        for (int i = 0; i < customers; i++)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Finish") { break; }
                if (input == "basket") { cost += 1.5; }
                else if (input == "wreath") { cost += 3.8; }
                else { cost += 7.00; }
                counter++;
            }
            if (counter % 2 == 0) { cost *= 0.8; }
            totalCost += cost;
            Console.WriteLine($"You purchased {counter} items for {cost:f2} leva.");
            cost = 0;
            counter = 0;
        }
        Console.WriteLine($"Average bill per client is: {(totalCost / customers):f2} leva.");
    }
}


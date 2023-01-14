using System;


public class Program
{
    public static void Main()
    {
        double size = double.Parse(Console.ReadLine());
        double suitcaseSizeTotal = 0;
        int count = 0;
        while (true)
        {

            string inputSize = Console.ReadLine();
            if (inputSize == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
                break;
            }
            count++;
            double suitcaseSize = double.Parse(inputSize);
            if (count % 3 == 0)
            {
                suitcaseSize *= 1.1;
            }
            if ((suitcaseSizeTotal + suitcaseSize) > size)
            {
                count--;
                Console.WriteLine("No more space!");
                break;
            }
            else
            {
                suitcaseSizeTotal += suitcaseSize;
            }

        }
        Console.WriteLine($"Statistic: {count} suitcases loaded.");
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static int doll = 0;
    private static int train = 0;
    private static int bear = 0;
    private static int bicycle = 0;

    private static Stack<int> materials = new Stack<int>(ReadArr());
    private static Queue<int> magicLevels = new Queue<int>(ReadArr());

    public static void Main(string[] args)
    {
        Crafting();

        PrintOutput();
    }

    private static void PrintOutput()
    {
        if ((doll > 0 && train > 0) || (bear > 0 && bicycle > 0)) { Console.WriteLine("The presents are crafted! Merry Christmas!"); }
        else { Console.WriteLine("No presents this Christmas!"); }

        if (materials.Any()) { Console.WriteLine($"Materials left: {string.Join(", ", materials.ToArray())}"); }

        if (magicLevels.Any()) { Console.WriteLine($"Magic left: {string.Join(", ", magicLevels.ToArray())}"); }

        if (bicycle > 0) { Console.WriteLine($"Bicycle: {bicycle}"); }
        if (doll > 0) { Console.WriteLine($"Doll: {doll}"); }
        if (bear > 0) { Console.WriteLine($"Teddy bear: {bear}"); }
        if (train > 0) { Console.WriteLine($"Wooden train: {train}"); }
    }

    private static void Crafting()
    {
        while (materials.Any() && magicLevels.Any())
        {
            int material = materials.Peek();
            if (material == 0)
            {
                materials.Pop();
                continue;
            }
            int magicLevel = magicLevels.Peek();
            if (magicLevel == 0)
            {
                magicLevels.Dequeue();
                continue;
            }
            materials.Pop();
            magicLevels.Dequeue();

            int product = material * magicLevel;
            if (product < 0)
            {
                int sum = material + magicLevel;
                materials.Push(sum);
            }
            else
            {
                switch (product)
                {
                    case 150: doll++; break;
                    case 250: train++; break;
                    case 300: bear++; break;
                    case 400: bicycle++; break;
                    default:
                        material += 15;
                        materials.Push(material);
                        break;
                }
            }
        }
    }

    public static int[] ReadArr()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static Queue<int> ingredients;
    private static Stack<int> freshnesLevels;

    private static int mimosa = 0;
    private static int daiquiri = 0;
    private static int sunshine = 0;
    private static int mojito = 0;
    public static void Main()
    {
        ingredients = new Queue<int>(ReadArr());
        freshnesLevels = new Stack<int>(ReadArr());

        while (ingredients.Any() && freshnesLevels.Any())
        {
            int ingredient = ingredients.Dequeue();
            if (ingredient == 0) { continue; }
            int freshnes = freshnesLevels.Pop();

            int product = ingredient * freshnes;

            switch (product)
            {
                case 150: mimosa++; break;
                case 250: daiquiri++; break;
                case 300: sunshine++; break;
                case 400: mojito++; break;
                default:
                    ingredients.Enqueue(ingredient += 5);
                    break;
            }
        }

        bool isSucceeded = mimosa > 0 && daiquiri > 0 & sunshine > 0 && mojito > 0;
        Console.WriteLine(isSucceeded ? "It's party time! The cocktails are ready!" : "What a pity! You didn't manage to prepare all cocktails.");
        
        if (ingredients.Any()) { Console.WriteLine($"Ingredients left: {ingredients.Sum()}");  }
        if (daiquiri > 0) { Console.WriteLine($"# Daiquiri --> {daiquiri}"); }
        if (mimosa > 0) { Console.WriteLine($"# Mimosa  --> {mimosa}"); }
        if (mojito > 0) { Console.WriteLine($"# Mojito  --> {mojito}"); }
        if (sunshine > 0) { Console.WriteLine($"# Sunshine  --> {sunshine}"); }
    }

    public static int[] ReadArr()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }
}

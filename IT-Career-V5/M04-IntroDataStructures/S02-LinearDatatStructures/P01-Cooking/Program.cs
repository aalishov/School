using System.Text;
using System.Collections.Generic;

public class Program
{
    private const int IncreaseIngredientValue = 3;
    private const int BreadValue = 25;
    private const int CakeValue = 50;
    private const int PastryValue = 75;
    private const int FruitPieValue = 100;

    private static int breadCounter = 0;
    private static int cakeCounter = 0;
    private static int pastryCounter = 0;
    private static int fruitPieCounter = 0;

    private static Queue<int> liquids;
    private static Stack<int> ingredients;
    public static void Main()
    {
        Initialise();

        Mix();

        PrintOutput();
    }

    private static void Initialise()
    {
        liquids = new Queue<int>(ReadIntArr());
        ingredients = new Stack<int>(ReadIntArr());
    }

    private static void PrintOutput()
    {
        bool isCooked = breadCounter > 0 && cakeCounter > 0 && pastryCounter > 0 && fruitPieCounter > 0;

        Console.WriteLine(isCooked ? Output.Cooked : Output.NoCooked);
        Console.WriteLine(liquids.Any() ? String.Format(Output.Liquids, String.Join(", ", liquids)) : Output.NoLiquids);
        Console.WriteLine(ingredients.Any() ? String.Format(Output.Ingredients, String.Join(", ", ingredients)) : Output.NoIngredients);
        Console.WriteLine(Output.PrintFoodCount(breadCounter, cakeCounter, fruitPieCounter, pastryCounter));
    }

    private static void Mix()
    {
        while (liquids.Any() && ingredients.Any())
        {
            int liquid = liquids.Dequeue();
            int ingredient = ingredients.Pop();
            int sum = liquid + ingredient;

            switch (sum)
            {
                case BreadValue: breadCounter++; break;
                case CakeValue: cakeCounter++; break;
                case PastryValue: pastryCounter++; break;
                case FruitPieValue: fruitPieCounter++; break;
                default:
                    ingredient += IncreaseIngredientValue;
                    ingredients.Push(ingredient);
                    break;
            }
        }
    }

    public static int[] ReadIntArr()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }
}

public class Output
{
    public const string Cooked = "Wohoo! You succeeded in cooking all the food!";
    public const string NoCooked = "Ugh, what a pity! You didn't have enough materials to cook everything.";
    public const string NoLiquids = "Liquids left: none";
    public const string Liquids = "Liquids left: {0}";
    public const string NoIngredients = "Ingredients left: none";
    public const string Ingredients = "Ingredients left: {0}";

    public static string PrintFoodCount(int bread, int cake, int pie, int pastry)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Bread: {bread}");
        sb.AppendLine($"Cake: {cake}");
        sb.AppendLine($"Fruit Pie: {pie}");
        sb.AppendLine($"Pastry: {pastry}");
        return sb.ToString().TrimEnd();
    }
}
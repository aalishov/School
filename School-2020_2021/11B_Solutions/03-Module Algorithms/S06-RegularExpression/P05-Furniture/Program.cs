using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    public static List<Furniture> furnitures = new List<Furniture>();
    static void Main()
    {

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Purchase")
            {
                PrintOutput(furnitures);
                break;
            }

            CreateFurniture(input);
        }

    }
    public static void CreateFurniture(string input)
    {
        //>>Sofa<<312.23!3
        string pattern = @">>(\w+)<<(\d+\.?\d*)!(\d+)";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {

            var gr = m.Groups;
            string name = gr[1].ToString();
            decimal price = decimal.Parse(gr[2].ToString());
            int quantity = int.Parse(gr[3].ToString());
            furnitures.Add(new Furniture(name, price, quantity));
        }
    }

    private static void PrintOutput(List<Furniture> furnitures)
    {
        Console.WriteLine("Bought furniture:");
        foreach (var furnitre in furnitures)
        {
            Console.WriteLine(furnitre);
        }
        Console.WriteLine($"Total money spend: {furnitures.Sum(x => x.TotalPrice())}");
    }
}


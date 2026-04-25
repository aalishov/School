using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



public class Program
{
    static Dictionary<int, Hat> hats = new Dictionary<int, Hat>();
    static Dictionary<string, HatShop> shops = new Dictionary<string, HatShop>();
    static void Main(string[] args)
    {
        string input;

        while ((input = Console.ReadLine()) != "STOP")
        {
            string[] splittedInput = input.Split(' ');
            string command = splittedInput[0];

            switch (command)
            {
                case "AddHat":
                    AddHat(splittedInput[1], splittedInput[2], double.Parse(splittedInput[3]), splittedInput[4]);
                    break;
                case "SellHat":
                    SellHat(splittedInput[1], splittedInput[2], double.Parse(splittedInput[3]), splittedInput[4]);
                    break;
                case "CalculateTotalPrice":
                    CalculateTotalPrice(splittedInput[1]);
                    break;
                case "GetHatWithHighestPrice":
                    GetHatWithHighestPrice(splittedInput[1]);
                    break;
                case "GetHatWithLowestPrice":
                    GetHatWithLowestPrice(splittedInput[1]);
                    break;
                case "RenameHatShop":
                    RenameHatShop(splittedInput[1], splittedInput[2]);
                    break;
                case "SellAllHats":
                    SellAllHats(splittedInput[1]);
                    break;
                case "HatShopInfo":
                    HatShopInfo(splittedInput[1]);
                    break;
                case "CreateHatShop":
                    CreateHatShop(splittedInput[1]);
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }

    }

    private static void AddHat(string type, string color, double price, string name)
    {
        try
        {
            Hat Hat = new Hat(type, color, price);
            if (!shops.ContainsKey(name))
            {
                Console.WriteLine("Could not add this hat to your shop.");
                return;
            }
            HatShop Shop = shops[name];
            Shop.AddHat(Hat);
            Console.WriteLine($"You added hat {type} with color {color} to shop {Shop.Name}.");

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void SellHat(string type, string color, double price, string name)
    {
        try
        {
            if (!shops.ContainsKey(name))
            {
                Console.WriteLine("Could not sell this hat from your shop.");
                return;
            }

            Hat Hat = new Hat(type, color, price);
            HatShop Shop = shops[name];
            if (Shop.SellHat(Hat))
            {
                Console.WriteLine($"You sold hat {type} with color {color} from hat shop {name}.");
            }
            else
            {
                Console.WriteLine($"Did not sell hat {type} with color {color} from hat shop {name}.");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void CalculateTotalPrice(string name)
    {
        try
        {
            if (!shops.ContainsKey(name))
            {
                Console.WriteLine("Could not calculate total price.");
                return;
            }
            HatShop Shop = shops[name];

            Console.WriteLine($"Total price: {Shop.CalculateTotalPrice():F2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void RenameHatShop(string name, string newName)
    {

        if (!shops.ContainsKey(name))
        {
            Console.WriteLine($"Could not rename the shop {name}.");
            return;
        }
        HatShop Shop = shops[name];

        try
        {
            Shop.RenameHatShop(newName);
            shops.Remove(name);
            shops.Add(newName, Shop);
            Console.WriteLine($"You renamed your shop from {name} to {newName}.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void SellAllHats(string name)
    {

        if (!shops.ContainsKey(name))
        {
            Console.WriteLine($"Could not sell all sats from shop {name}.");
            return;
        }
        HatShop Shop = shops[name];

        Shop.SellAllHats();
        Console.WriteLine($"You sold all hats from shop {name}.");
    }

    private static void HatShopInfo(string name)
    {
        if (!shops.ContainsKey(name))
        {
            Console.WriteLine($"Could not get shop {name}.");
            return;
        }
        HatShop Shop = shops[name];
        Console.WriteLine(Shop.ToString());
    }

    private static void GetHatWithLowestPrice(string name)
    {

        if (!shops.ContainsKey(name))
        {
            Console.WriteLine($"Could not get hat with lowest price from shop {name}.");
            return;
        }
        HatShop Shop = shops[name];

        Console.WriteLine($"Hat from shop {name} has lowest price: {Shop.GetHatWithLowestPrice().Price:F2}");
    }

    private static void GetHatWithHighestPrice(string name)
    {

        if (!shops.ContainsKey(name))
        {
            Console.WriteLine($"Could not get hat with highest price from shop {name}.");
            return;
        }
        HatShop Shop = shops[name];

        Console.WriteLine($"Hat from shop {name} has highest price: {Shop.GetHatWithHighestPrice().Price:F2}");
    }


    private static void CreateHatShop(string name)
    {

        try
        {
            HatShop Shop = new HatShop(name);
            shops.Add(name, Shop);
            Console.WriteLine($"You created hat shop {name}.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);

        }
    }
}


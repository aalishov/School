using System;
using System.Collections.Generic;

public class Program
{
    static Dictionary<string, FurnitureStore> stores = new Dictionary<string, FurnitureStore>();
    static void Main(string[] args)
    {
        string input;

        while ((input = Console.ReadLine()) != "STOP")
        {
            string[] splittedInput = input.Split(' ');
            string command = splittedInput[0];

            switch (command)
            {
                case "AddFurniture":
                    AddFurniture(splittedInput[1], splittedInput[2], double.Parse(splittedInput[3]), splittedInput[4]);
                    break;
                case "SellFurniture":
                    SellFurniture(splittedInput[1], splittedInput[2], double.Parse(splittedInput[3]), splittedInput[4]);
                    break;
                case "CalculateTotalPrice":
                    CalculateTotalPrice(splittedInput[1]);
                    break;
                case "GetFurnitureWithHighestPrice":
                    GetFurnitureWithHighestPrice(splittedInput[1]);
                    break;
                case "GetFurnitureWithLowestPrice":
                    GetFurnitureWithLowestPrice(splittedInput[1]);
                    break;
                case "RenameFurnitureStore":
                    RenameFurnitureStore(splittedInput[1], splittedInput[2]);
                    break;
                case "SellAllFurnitures":
                    SellAllFurnitures(splittedInput[1]);
                    break;
                case "FurnitureStoreInfo":
                    FurnitureStoreInfo(splittedInput[1]);
                    break;
                case "CreateFurnitureStore":
                    CreateFurnitureStore(splittedInput[1]);
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }

    }

    private static void AddFurniture(string type, string color, double price, string name)
    {
        try
        {
            Furniture furniture = new Furniture(type, color, price);
            if (!stores.ContainsKey(name))
            {
                Console.WriteLine("Could not add this furniture to your store.");
                return;
            }
            FurnitureStore store = stores[name];
            store.AddFurniture(furniture);
            Console.WriteLine($"You added furniture {type} with color {color} to store {store.Name}.");

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void SellFurniture(string type, string color, double price, string name)
    {
        try
        {
            if (!stores.ContainsKey(name))
            {
                Console.WriteLine("Could not sell this furniture from your store.");
                return;
            }

            Furniture furniture = new Furniture(type, color, price);
            FurnitureStore store = stores[name];
            if (store.SellFurniture(furniture))
            {
                Console.WriteLine($"You sold furniture {type} with color {color} from furniture store {name}.");
            }
            else
            {
                Console.WriteLine($"Did not sell furniture {type} with color {color} from furniture store {name}.");
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
            if (!stores.ContainsKey(name))
            {
                Console.WriteLine("Could not calculate total price.");
                return;
            }
            FurnitureStore store = stores[name];

            Console.WriteLine($"Total price: {store.CalculateTotalPrice():F2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void RenameFurnitureStore(string name, string newName)
    {

        if (!stores.ContainsKey(name))
        {
            Console.WriteLine($"Could not rename the store {name}.");
            return;
        }
        FurnitureStore store = stores[name];

        try
        {
            store.RenameFurnitureStore(newName);
            stores.Remove(name);
            stores.Add(newName, store);
            Console.WriteLine($"You renamed your store from {name} to {newName}.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void SellAllFurnitures(string name)
    {

        if (!stores.ContainsKey(name))
        {
            Console.WriteLine($"Could not sell all furnitures from store {name}.");
            return;
        }
        FurnitureStore store = stores[name];

        store.SellAllFurnitures();
        Console.WriteLine($"You sold all furnitures from store {name}.");
    }

    private static void FurnitureStoreInfo(string name)
    {
        if (!stores.ContainsKey(name))
        {
            Console.WriteLine($"Could not get store {name}.");
            return;
        }
        FurnitureStore store = stores[name];
        Console.WriteLine(store.ToString());
    }

    private static void GetFurnitureWithLowestPrice(string name)
    {

        if (!stores.ContainsKey(name))
        {
            Console.WriteLine($"Could not get furniture with lowest price from store {name}.");
            return;
        }
        FurnitureStore store = stores[name];

        Console.WriteLine($"Furniture from store {name} has lowest price: {store.GetFurnitureWithLowestPrice().Price:F2}");
    }

    private static void GetFurnitureWithHighestPrice(string name)
    {

        if (!stores.ContainsKey(name))
        {
            Console.WriteLine($"Could not get furniture with highest price from store {name}.");
            return;
        }
        FurnitureStore store = stores[name];

        Console.WriteLine($"Furniture from store {name} has highest price: {store.GetFurnitureWithHighestPrice().Price:F2}");
    }


    private static void CreateFurnitureStore(string name)
    {

        try
        {
            FurnitureStore store = new FurnitureStore(name);
            stores.Add(name, store);
            Console.WriteLine($"You created furniture store {name}.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);

        }
    }
}


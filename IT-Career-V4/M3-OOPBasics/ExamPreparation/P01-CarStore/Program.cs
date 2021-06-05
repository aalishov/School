using System;
using System.Collections.Generic;

public class Program
{
    static Dictionary<int, Car> cars = new Dictionary<int, Car>();
    static Dictionary<string, Store> stores = new Dictionary<string, Store>();

    static void Main(string[] args)
    {
        string input;

        while ((input = Console.ReadLine()) != "STOP")
        {
            string[] splittedInput = input.Split(' ');
            string command = splittedInput[0];

            switch (command)
            {
                case "AddCar":
                    AddCar(int.Parse(splittedInput[1]), double.Parse(splittedInput[2]), splittedInput[3]);
                    break;
                case "SellCar":
                    SellCar(int.Parse(splittedInput[1]), double.Parse(splittedInput[2]), splittedInput[3]);
                    break;
                case "CalculateTotalPrice":
                    CalculateTotalPrice(splittedInput[1]);
                    break;
                case "GetCarWithHighestPrice":
                    GetCarWithHighestPrice(splittedInput[1]);
                    break;
                case "GetCarWithLowestPrice":
                    GetCarWithLowestPrice(splittedInput[1]);
                    break;
                case "RenameStore":
                    RenameStore(splittedInput[1], splittedInput[2]);
                    break;
                case "SellAllCars":
                    SellAllCars(splittedInput[1]);
                    break;
                case "StoreInfo":
                    StoreInfo(splittedInput[1]);
                    break;
                case "CreateStore":
                    CreateStore(splittedInput[1]);
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }

    }

    private static void AddCar(int number, double price, string name)
    {
        try
        {
            Car car = new Car(number, price);
            if (!stores.ContainsKey(name))
            {
                Console.WriteLine("Could not add this car to your store.");
                return;
            }
            Store store = stores[name];
            store.AddCar(car);
            Console.WriteLine($"You added car with number {number} to store {store.Name}.");

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void SellCar(int number, double price, string name)
    {
        try
        {
            if (!stores.ContainsKey(name))
            {
                Console.WriteLine("Could not sell this car from your store.");
                return;
            }

            Car car = new Car(number, price);
            Store store = stores[name];
            if (store.SellCar(car))
            {
                Console.WriteLine($"You sold car with number {number} from store {name}.");
            }
            else
            {
                Console.WriteLine($"Did not sell car  with number {number} from store {name}.");
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
            Store store = stores[name];

            Console.WriteLine($"Total price: {store.CalculateTotalPrice():F2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void RenameStore(string name, string newName)
    {

        if (!stores.ContainsKey(name))
        {
            Console.WriteLine($"Could not rename the store {name}.");
            return;
        }
        Store store = stores[name];

        try
        {
            store.RenameStore(newName);
            stores.Remove(name);
            stores.Add(newName, store);
            Console.WriteLine($"You renamed your store from {name} to {newName}.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void SellAllCars(string name)
    {

        if (!stores.ContainsKey(name))
        {
            Console.WriteLine($"Could not sell all cars store {name}.");
            return;
        }
        Store store = stores[name];

        store.SellAllCars();
        Console.WriteLine($"You sold all cars from store {name}.");
    }

    private static void StoreInfo(string name)
    {
        if (!stores.ContainsKey(name))
        {
            Console.WriteLine($"Could not get store {name}.");
            return;
        }
        Store store = stores[name];
        Console.WriteLine(store.ToString());
    }

    private static void GetCarWithLowestPrice(string name)
    {

        if (!stores.ContainsKey(name))
        {
            Console.WriteLine($"Could not get car with lowest price from store {name}.");
            return;
        }
        Store store = stores[name];

        Console.WriteLine($"Car from store {name} has lowest price: {store.GetCarWithLowestPrice().Price:F2}");
    }

    private static void GetCarWithHighestPrice(string name)
    {

        if (!stores.ContainsKey(name))
        {
            Console.WriteLine($"Could not get car with highest price from store {name}.");
            return;
        }
        Store store = stores[name];

        Console.WriteLine($"Car from store {name} has highest price: {store.GetCarWithHighestPrice().Price:F2}");
    }


    private static void CreateStore(string name)
    {

        try
        {
            Store store = new Store(name);
            stores.Add(name, store);
            Console.WriteLine($"You created store {name}.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);

        }
    }


}


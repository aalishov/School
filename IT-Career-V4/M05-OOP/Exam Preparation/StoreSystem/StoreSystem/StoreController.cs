using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StoreController
{
    private readonly List<Store> stores;
    public StoreController()
    {
        stores = new List<Store>();
    }
    public string CreateStore(List<string> args)
    {
        string name = args[0];
        string type = args[1];
        if (stores.Any(x => x.Name == name))
        {
            return $"Store {name} is already registered!";
        }
        stores.Add(new Store(name, type));
        return $"Store {name} was successfully registerd in the system!";
    }
    public string ReceiveProduct(List<string> args)
    {
        string productName = args[1];
        string type = args[0];
        int quantity = int.Parse(args[2]);
        double price = double.Parse(args[3]);
        double markup = double.Parse(args[4]);
        string storeName = args[5];

        Store store = stores.FirstOrDefault(x => x.Name == storeName);
        if (store == null)
        {
            return InvalidStore(storeName);
        }
        bool isReceive = false;
        if (type == "Food")
        {
            isReceive = store.ReceiveProduct(new Food(productName, quantity, price, markup));
        }
        else if (type == "Drink")
        {
            isReceive = store.ReceiveProduct(new Drink(productName, quantity, price, markup));
        }
        else
        {
            return $"Product {type} is invalid!";
        }
        if (isReceive)
        {
            return $"Product {productName} was successfully delivered to {storeName}!";
        }
        return $"Product {productName} was already delivered to {storeName}!";
    }
    public string SellProduct(List<string> args)
    {
        string productName = args[0];
        int quantity = int.Parse(args[1]);
        string storeName = args[2];

        Store store = stores.FirstOrDefault(x => x.Name == storeName);
        if (store == null)
        {
            return InvalidStore(storeName);
        }
        bool isSell = store.SellProduct(productName, quantity);
        if (isSell)
        {
            return $"Product {productName} was successfully bought from {storeName}!";
        }
        return $"Product {productName} was already sold out!";
    }
    public string StoreInfo(List<string> args)
    {
        string storeName = args[0];
        Store store = stores.FirstOrDefault(x => x.Name == storeName);
        if (store != null)
        {
            return store.ToString();
        }
        return InvalidStore(storeName);
    }
    public string Shutdown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Stores: {stores.Count}");
        foreach (var s in stores.OrderByDescending(x=>x.Revenue).ThenBy(x=>x.Name))
        {
            sb.AppendLine($"{s.ToString()}");
        }
        sb.AppendLine($"System Store Revenues: {stores.Sum(x=>x.Revenue):f2}BGN");
        return sb.ToString();
    }
    private static string InvalidStore(string storeName)
    {
        return $"Invalid Store: {storeName}. Cannot find it in system!";
    }
}


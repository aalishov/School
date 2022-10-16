using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class StoreController
{
    private Dictionary<string, Store> stores = new Dictionary<string, Store>();
    public string CreateStore(List<string> args)
    {
        string name = args[1];
        string type = args[2];
        if (this.stores.ContainsKey(name))
        {
            return $"Store {name} is already registered!";
        }
        this.stores.Add(name, new Store(name, type));
        return $"Store {name} was successfully registerd in the system!";
    }
    public string ReceiveProduct(List<string> args)
    {
        string type = args[1];
        string productName = args[2];
        int quantity = int.Parse(args[3]);
        double deliverPrice = double.Parse(args[4]);
        double percentageMarkup = double.Parse(args[5]);
        string storeName = args[6];
        if (this.stores.ContainsKey(storeName))
        {
            Product product = null;
            switch (type)
            {
                case "Food":
                    product = new Food(productName, quantity, deliverPrice, percentageMarkup);
                    break;
                case "Drink":
                    product = new Drink(productName, quantity, deliverPrice, percentageMarkup);
                    break;
                default:
                    return $"Product {type} is invalid!";
            }
            bool isReceived = this.stores[storeName].ReceiveProduct(product);
            if (isReceived)
            {
                return $"Product {productName} was successfully delivered to {storeName}!";
            }
                return $"Product {productName} was already delivered to {storeName}!";
        }
        return $"Invalid Store: {storeName}. Cannot find it in system!";
    }
    public string SellProduct(List<string> args)
    {
        string productName = args[1];
        int quantity = int.Parse(args[2]);
        string storeName = args[3];
        if (this.stores.ContainsKey(storeName))
        {
            bool isBought = this.stores[storeName].SellProduct(productName, quantity);
            if (isBought)
            {
                return $": Product {productName} was successfully bought from {storeName}!";
            }
            return $"Product {productName} was already sold out!";
        }
        return $"Invalid Store: {storeName}. Cannot find it in system!";
    }
    public string StoreInfo(List<string> args)
    {
        string storeName = args[1];
        if (this.stores.ContainsKey(storeName))
        {
            return this.stores[storeName].ToString();
        }
        return $"Invalid Store: {storeName}. Cannot find it in system!";
    }
    public string Shutdown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Stores: {this.stores.Count}");
        foreach (var store in this.stores
            .OrderByDescending(x=>x.Value.Revenue)
            .ThenBy(x=>x.Value.Name))
        {
            sb.AppendLine(store.Value.ToString());
        }
        sb.AppendLine($"System Store Revenues: {this.stores.Sum(x=>x.Value.Revenue):f2}BGN");
        return sb.ToString().TrimEnd();
    }
}


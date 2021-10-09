using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Store
{
    private readonly List<Product> products;
    private string name;
    private string type;

    public Store(string name, string type)
    {
        Name = name;
        Type = type;
        products = new List<Product>();
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Store name must not be null or empty!");
            }
            name = value;
        }
    }
    public string Type
    {
        get { return type; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Store type must not be null or empty!");
            }
            type = value;
        }
    }
    public double Revenue { get; private set; }

    public bool ReceiveProduct(Product product)
    {
        if (!products.Any(x => x.Name == product.Name))
        {
            this.products.Add(product);
            return true;
        }
        return false;
    }

    public bool SellProduct(string name, int quantity)
    {
        Product product = products.FirstOrDefault(x => x.Name == name);
        if (product == null) { return false; }
        if (product.Quantity < quantity) { return false; }
        if (product.Quantity - quantity > 0)
        {
            product.Quantity -= quantity;
        }
        else
        {
            products.Remove(product);
        }
        Revenue += quantity * product.FinalPrice;
        return true;
    }
    public Product GetProduct(string name)
    {
        return products.FirstOrDefault(x => x.Name == name);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"****Store: {Name} <{Type}>");
        sb.AppendLine($"****Available products: <{products.Count}>");
        foreach (var p in products)
        {
            sb.AppendLine($"****** {p.Name} ({p.Quantity})");
        }
        sb.AppendLine($"****Revenue: <{Revenue:f2}BGN>");
        return sb.ToString().TrimEnd();
    }
}


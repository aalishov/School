using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Store
{
    private string name;
    private string type;
    private readonly List<Product> products;

    public Store(string name, string type)
    {
        this.Name = name;
        this.Type = type;
        this.products = new List<Product>();
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Store name must not be null or empty!");
            }
            this.name = value;
        }
    }
    public string Type
    {
        get { return this.type; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Store type must not be null or empty!");
            }
            this.type = value;
        }
    }
    //TODO: Check Revenue Property
    public double Revenue { get; private set; }

    public bool ReceiveProduct(Product product)
    {
        Product p = GetProduct(product.Name);
        if (p == null)
        {
            this.products.Add(product);
            return true;
        }
        return false;
    }
    public bool SellProduct(string name, int quantity)
    {
        Product p = GetProduct(name);
        if (p != null && p.Quantity >= quantity)
        {
            p.Quantity -= quantity;
            if (p.Quantity == 0)
            {
                this.products.Remove(p);
            }
            this.Revenue += (quantity * p.FinalPrice);
            return true;
        }
        return false;
    }
    public Product GetProduct(string name)
    {
        //for (int i = 0; i < this.products.Count; i++)
        //{
        //    if (products[i].Name == name)
        //    {
        //        return products[i];
        //    }
        //}
        //return null;
        return this.products.FirstOrDefault(x => x.Name == name);
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"****Store: {this.Name} <{this.Type}>");
        sb.AppendLine($"****Available products: <{this.products.Count}>");
        this.products.ForEach(x => sb.AppendLine($"****** {x.Name} ({x.Quantity})"));
        sb.AppendLine($"****Revenue: <{this.Revenue:f2}BGN>");
        return sb.ToString().TrimEnd();
    }
}


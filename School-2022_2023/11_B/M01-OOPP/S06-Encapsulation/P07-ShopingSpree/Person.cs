using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    private readonly List<Product> bagOfProducts;
    private string name;
    private double money;

    public Person(string name, double money)
    {
        Name = name;
        Money = money;
        bagOfProducts = new List<Product>();
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            name = value;
        }
    }
    public double Money
    {
        get { return money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            money = value;
        }
    }
    public IReadOnlyList<Product> Products { get { return bagOfProducts; } }

    public string AddProduct(Product product)
    {
        if (product.Cost <= Money)
        {
            bagOfProducts.Add(product);
            Money -= product.Cost;
            return $"{Name} bought {product}";
        }
        return $"{Name} can't afford {product.Name}";
    }
    public override string ToString()
    {
        return $"{Name} - {string.Join(", ", bagOfProducts.Select(x => x.Name))}";
    }
}


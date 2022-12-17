using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
    private string name;
    private double cost;
    public Product(string name, double cost)
    {
        Name = name;
        Cost = cost;
    }
    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            name = value;
        }
    }
    public double Cost
    {
        get { return cost; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            cost = value;
        }
    }
    public override string ToString()
    {
        return $"Name: {Name}, Cost: {Cost:C2}";
    }
}


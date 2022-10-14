using System;
using System.Diagnostics.CodeAnalysis;

public class Item : IComparable<Item>
{
    private string description;
    private double price;

    public Item(string description, double price)
    {
        this.Description = description;
        this.Price = price;
    }
    public string Description
    {
        get { return description; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Invalid description!");
            }
            description = value;
        }
    }
    public double Price
    {
        get { return price; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid price!");
            }
            price = value;
        }
    }

    public int CompareTo([AllowNull] Item other)
    {
        
        if (this.Price < other.Price)
        { 
            return -1;
        }
        else if(this.Price>other.Price)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public override string ToString()
    {
        return $"{this.Description} ({this.Price})";
    }
}


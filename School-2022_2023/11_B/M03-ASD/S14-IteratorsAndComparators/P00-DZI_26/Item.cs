using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

public class Item : IComparable<Item>
{
    private double price;
    private string description;

    public Item(string description, double price)
    {
        this.Description = description;
        this.Price = price;
    }

    public string Description
    {
        get => description;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid description!");
            }
            description = value;
        }
    }
    public double Price
    {
        get => price;

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid price");
            }
            price = value;
        }
    }

    public int CompareTo([AllowNull] Item other)
    {
        int resultD = this.Description.CompareTo(other.Description);
        int resulP = this.Price.CompareTo(other.Price);

        if (resultD != 0) { return resultD; }
        else if (resulP != 0) { return resulP; }
        return 0;
    }

    public override string ToString()
    {
        return $"{Description} ({Price:f2})";
    }
}
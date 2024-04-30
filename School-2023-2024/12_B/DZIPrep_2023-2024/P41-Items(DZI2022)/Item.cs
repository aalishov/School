using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
                throw new ArgumentException("Invalid data");
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
                throw new ArgumentException("Invalid data");
            }
            price = value;
        }
    }

    public int CompareTo(Item? other)
    {
        if (this.Description.CompareTo(other.Description) > 0)
        {
            return 1;
        }
        else if (this.Description.CompareTo(other.Description) < 0)
        {
            return -1;
        }
        else if (this.Price < other.Price)
        {
            return -1;
        }
        else if (this.Price > other.Price)
        {
            return 1;
        }
        return 0;
    }
    public override string ToString()
    {
        return $"{this.Description} ({this.Price})";
    }
}
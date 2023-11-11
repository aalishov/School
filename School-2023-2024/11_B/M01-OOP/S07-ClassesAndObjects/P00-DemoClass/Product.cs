using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Product
{
    private string name;
    private double weight;

    public Product(string name, string type, double weight, double width, double height)
    {
        Name = name;
        Type = type;
        Weight = weight;
        Width = width;
        Height = height;
    }

    public Product(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid name");
            }
            name = value;
        }
    }

    public string Type { get; set; }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid weight1");
            }
            weight = value;
        }
    }

    public double Width { get; set; }

    public double Height { get; set; }
}


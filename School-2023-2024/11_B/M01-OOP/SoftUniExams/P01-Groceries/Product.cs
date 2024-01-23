using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; private set; }

    public double Price { get; private set; }

    public override string ToString()
    {
        return $"{Name}: {Price:F2}$";
    }
}


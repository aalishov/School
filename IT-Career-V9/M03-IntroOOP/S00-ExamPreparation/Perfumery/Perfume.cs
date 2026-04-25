using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Perfume
{
    private string brand;

    private double price;

    //set and get method
    public Perfume(string brand, double price)
    {
        Price = price;
        Brand = brand;
    }
    public double Price
    {
        get
        {
            return price;
        }
        private set
        {
            if (value > 100)
            {
                throw new ArgumentException("Invalid perfume price!");
            }
            price = value;

        }
    }
    public string Brand
    {
        get
        {
            return brand;
        }
        private set
        {
            brand = value;
        }
    }

    public override string ToString()
    {
        return $"Perfume {Brand} costs {Price:F2}";
    }
}


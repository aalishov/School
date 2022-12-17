using System;
using System.Collections.Generic;
using System.Text;


public class Product
{
    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public string Name { get; private set; }
    public decimal Price { get;private  set; }
}


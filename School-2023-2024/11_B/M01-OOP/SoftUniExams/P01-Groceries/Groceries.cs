using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Groceries
{
    private List<Product> products;

    public Groceries(int capacity)
    {
        Capacity = capacity;
        Turnover = 0;
        products = new List<Product>();
    }

    public int Capacity { get; private set; }

    public double Turnover { get; private set; }

    public void Add(Product product)
    {
        if (Capacity <= products.Count || products.Any(x => x.Name == product.Name))
        {
            return;
        }
        products.Add(product);
    }
}


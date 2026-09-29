using System;
using System.Collections.Generic;
using System.Text;


public class CoffeeShop
{
    private readonly List<Coffee> coffees;

    public CoffeeShop(string name)
    {
        Name = name;
        coffees = new List<Coffee>();
    }

    public string Name { get; private set; }

    public IReadOnlyList<Coffee> Coffees { get { return coffees; } }

    public void AddCoffee(string type, double price)
    {
        coffees.Add(new Coffee(type, price));
    }

    public double AveragePriceInRange(double start, double end)
    {
        return coffees
            .Where(c => c.Price >= start && c.Price <= end)
            .Average(c => c.Price);
    }

    public bool CheckCoffeeIsInCoffeeShop(string type)
    {
        return coffees.Any(x => x.Type == type);
    }

    public List<string> FilterCoffeesByPrice(double price)
    {
        return coffees
            .Where(c => c.Price < price)
            .Select(c => c.Type)
            .ToList();
    }

    public string[] ProvideInformationAboutAllCoffees()
    {
        return coffees
            .Select(c => c.ToString())
            .ToArray();
    }

    public void SortAscendingByType()
    {
        List<Coffee> sorted = coffees.OrderBy(c => c.Type).ToList();
        coffees.Clear();
        coffees.AddRange(sorted);
    }

    public void SortDescendingByPrice()
    {
        List<Coffee> sorted = coffees.OrderByDescending(c => c.Price).ToList();
        coffees.Clear();
        coffees.AddRange(sorted);
    }
}



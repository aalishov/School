using System;
using System.Collections.Generic;
using System.Text;

public class SkateboardShop
{
    private readonly List<Skateboard> skateboards;

    public SkateboardShop(string name)
    {
        Name = name;
        skateboards = new List<Skateboard>();
    }

    public string Name { get; private set; }

    public IReadOnlyList<Skateboard> Skateboards { get { return skateboards; } }

    public void AddSkateboard(string model, double price)
    {
        Skateboard skateboard = new Skateboard(model, price);
        skateboards.Add(skateboard);
    }

    public string[] ProvideInformationAboutAllSkateboards()
    {
        string[] information = new string[skateboards.Count];
        for (int i = 0; i < skateboards.Count; i++)
        {
            information[i] = skateboards[i].ToString();
        }
        return information;
    }

    public bool CheckSkateboardIsInShop(string model)
    {
        return skateboards.Any(s => s.Model == model);
    }

    public void SortDescendingByPrice()
    {
        List<Skateboard> sorted = skateboards.OrderByDescending(s => s.Price).ToList();
        skateboards.Clear();
        skateboards.AddRange(sorted);
    }

    public void SortAscendingByModel()
    {
        List<Skateboard> sorted = skateboards.OrderBy(s => s.Model).ToList();
        skateboards.Clear();
        skateboards.AddRange(sorted);
    }

    public List<string> FilterSkateboardsByPrice(double price)
    {
        return skateboards.Where(s => s.Price < price).Select(s => s.Model).ToList();
    }

    public double AveragePriceInRange(double start, double end)
    {
        return skateboards
            .Where(s => s.Price >= start && s.Price <= end)
            .Average(s=>s.Price);
    }
}


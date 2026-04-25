using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Perfumery
{
    private string name;
    private List<Perfume> perfumes;

    public Perfumery(string name)
    {
        Name = name;
        perfumes = new List<Perfume>();
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (value.Length < 6)
            {
                throw new ArgumentException("Invalid perfumery name!");
            }
            name = value;
        }
    }

    public void AddPerfume(Perfume perfume)
    {
        perfumes.Add(perfume);
    }

    public bool SellPerfume(Perfume perfume)
    {
        Perfume remove = perfumes.FirstOrDefault(p => p.Brand == perfume.Brand && p.Price == perfume.Price);
        return perfumes.Remove(remove);
    }

    public double CalculateTotalPrice()
    {
        return perfumes.Sum(p => p.Price);
    }

    public Perfume GetPerfumeWithHighestPrice()
    {
        return perfumes.OrderByDescending(p => p.Price).FirstOrDefault();
    }

    public Perfume GetPerfumeWithLowestPrice()
    {
        return perfumes.OrderBy(p => p.Price).FirstOrDefault();
    }

    public void RenamePerfumery(string newName)
    {
        Name = newName;
    }

    public void SellAllPerfumes()
    {
        perfumes.Clear();
    }

    public override string ToString()
    {
        if (!perfumes.Any()) { return $"Perfumery {Name} has no available perfumes."; }
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Perfumery {Name} has {perfumes.Count} perfume/s:");
        foreach (var perfume in perfumes)
        {
            sb.AppendLine(perfume.ToString());
        }
        return sb.ToString().TrimEnd();
    }
}


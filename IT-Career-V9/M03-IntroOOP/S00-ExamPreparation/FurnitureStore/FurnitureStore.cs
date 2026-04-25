using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FurnitureStore
{
    private readonly List<Furniture> furnitures;
    private string name;
    public FurnitureStore(string name)
    {
        Name = name;
        furnitures = new List<Furniture>();
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 6) { throw new ArgumentException("Invalid furniture store name!"); }
            name = value;
        }
    }

    public void AddFurniture(Furniture furniture)
    {
        furnitures.Add(furniture);
    }

    public bool SellFurniture(Furniture furniture)
    {
        Furniture furnitureToSell = furnitures.FirstOrDefault(f => f.Type == furniture.Type && f.Color == furniture.Color && f.Price == furniture.Price);
        return furnitures.Remove(furnitureToSell);
    }

    public double CalculateTotalPrice()
    {
        return furnitures.Sum(f => f.Price);
    }

    public Furniture GetFurnitureWithHighestPrice()
    {
        return furnitures.OrderByDescending(f => f.Price).FirstOrDefault();
    }

    public Furniture GetFurnitureWithLowestPrice()
    {
        return furnitures.OrderBy(f => f.Price).FirstOrDefault();
    }

    public void RenameFurnitureStore(string newName)
    {
        Name = newName;
    }

    public void SellAllFurnitures()
    {
        furnitures.Clear();
    }

    public override string ToString()
    {
        if (!furnitures.Any())
        {
            return $"Furniture store {Name} has no available furnitures.";
        }
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Furniture store {Name} has {furnitures.Count} furniture/s:");
        furnitures.ForEach(f => sb.AppendLine(f.ToString()));
        return sb.ToString().TrimEnd();
    }
}

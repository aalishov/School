using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

public class FlowerStore
{
    private readonly List<Flower> flowers;
    private string name;

    public FlowerStore(string name)
    {
        Name = name;
        flowers = new List<Flower>();
    }

    public string Name
    {
        get => name; private set
        {
            if (value.Length<6)
            {
                throw new ArgumentException("Invalid flower store name!");
            }
            name = value;
        }
    }

    public void AddFlower(Flower flower)
    {
        flowers.Add(flower);
    }

    public bool SellFlower(Flower flower)
    {
        Flower f = flowers.FirstOrDefault(x => x.Type == flower.Type && x.Color == flower.Color && x.Price == flower.Price);
        return flowers.Remove(f);
        // return flowers.Remove(flower);
    }

    public double CalculateTotalPrice()
    {
        return flowers.Sum(x => x.Price);
    }

    public Flower GetFlowerWithHighestPrice()
    {
        return flowers.OrderBy(x => x.Price).LastOrDefault();
    }
    public Flower GetFlowerWithLowestPrice()
    {
        return flowers.OrderBy(x => x.Price).FirstOrDefault();
    }

    public void RenameFlowerStore(string newName)
    {
        Name = newName;
    }

    public void SellAllFlowers()
    {
        flowers.Clear();
    }

    public override string ToString()
    {
        if (!flowers.Any())
        {
            return $"Flower store {Name} has no available flowers.";
        }
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Flower store {Name} has {flowers.Count} flower/s:");
        foreach (Flower flower in flowers)
        {
            sb.AppendLine(flower.ToString());
        }
        return sb.ToString().TrimEnd();
    }
}


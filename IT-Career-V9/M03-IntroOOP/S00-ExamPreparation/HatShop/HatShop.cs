using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class HatShop
{
    private string name;
    private readonly List<Hat> hats;

    public HatShop(string name)
    {
        Name = name;
        hats = new List<Hat>();
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (value.Length < 6)
            {
                throw new ArgumentException("Invalid hat shop name!");
            }
            name = value;
        }
    }

    public void AddHat(Hat hat)
    {
        hats.Add(hat);
    }

    public bool SellHat(Hat hat)
    {
        Hat h = hats.FirstOrDefault(x => x.Color == hat.Color && x.Type == hat.Type && x.Price == hat.Price);
        return hats.Remove(h);
    }

    public double CalculateTotalPrice()
    {
        return hats.Sum(x => x.Price);
    }

    public Hat GetHatWithHighestPrice()
    {
        return hats.OrderBy(x => x.Price).LastOrDefault();
    }

    public Hat GetHatWithLowestPrice()
    {
        return hats.OrderBy(x => x.Price).FirstOrDefault();
    }

    public void RenameHatShop(string newName)
    {
        Name = newName;
    }

    public void SellAllHats()
    {
        hats.Clear();
    }

    public override string ToString()
    {
        if (!hats.Any())
        {
            return $"Hat Shop {Name} has no available hats.";
        }
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Hat Shop {Name} has {hats.Count} hat/s:");
        hats.ForEach(x => { sb.AppendLine(x.ToString()); });
        return sb.ToString().TrimEnd();
    }
}



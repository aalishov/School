using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class FurnitureStore
{
    private readonly List<Furniture> furnitures;

    public FurnitureStore(string name)
    {
        this.Name = name;
        this.furnitures = new List<Furniture>();
    }

    public string Name { get;private set; }

    public void AddFurniture(Furniture furniture)
    {
        furnitures.Add(furniture);
    }

    public bool SellFurniture(Furniture furniture)
    {
       return furnitures.Remove(furniture);
    }

    public double CalculateTotalPrice()
    {
        return furnitures.Sum(x => x.Price);
    }

    public void RenameFurnitureStore(string newName)
    {
        this.Name=newName;
    }

    public void SellAllFurnitures()
    {
        furnitures.Clear();
    }
    public override string ToString()
    {
        if (furnitures.Count>0)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Furniture store {Name} has {furnitures.Count} furniture / s:");
            foreach (Furniture f in furnitures)
            {
                sb.AppendLine(f.ToString());
            }
            return sb.ToString().TrimEnd();

        }
        return $"Furniture store {Name} has no available furnitures";
    }
}


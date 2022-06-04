using System.Text;

public class FurnitureStore
{
    private readonly List<Furniture> furnitures;
    private string name;

    public FurnitureStore(string name)
    {
        this.Name = name;
        this.furnitures = new List<Furniture>();
    }
    public string Name
    {
        get { return this.name; }
        private set
        {
            if (value.Length<6)
            {
                throw new ArgumentException("Invalid furniture store name!");
            }
            this.name = value;
        }
    }
    public int Count { get { return this.furnitures.Count; } }
    public void AddFurniture(Furniture furniture)
    {
        this.furnitures.Add(furniture);
    }
    public bool SellFurniture(Furniture furniture)
    {
        Furniture remove = this.furnitures.FirstOrDefault(f =>
        f.Type == furniture.Type
        && f.Color == furniture.Color
        && f.Price == furniture.Price);
        return this.furnitures.Remove(remove);
    }
    public double CalculateTotalPrice()
    {
        return this.furnitures.Sum(f => f.Price);
    }
    public Furniture GetFurnitureWithHighestPrice()
    {
        return furnitures.OrderByDescending(f => f.Price).FirstOrDefault();
    }
    public Furniture GetFurnitureWithLowestPrice()
    {
        return furnitures.OrderByDescending(f => f.Price).LastOrDefault();
    }
    public void RenameFurnitureStore(string newName)
    {
        this.Name = newName;
    }
    public void SellAllFurnitures()
    {
        this.furnitures.Clear();
    }
    public override string ToString()
    {
        if (furnitures.Any())
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Furniture store {this.Name} has {this.Count} furniture/s:");
            foreach (var furniture in this.furnitures)
            {
                sb.AppendLine(furniture.ToString());
            }
            return sb.ToString().TrimEnd();
        }
        return $"Furniture store {this.Name} has no available furnitures.";
    }
}


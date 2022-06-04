using System.Text;

public class FlowerStore
{
    private readonly List<Flower> flowers;
    private string name;

    public FlowerStore(string name)
    {
        this.Name = name;
        flowers = new List<Flower>();
    }
    public string Name
    {
        get { return this.name; }
        private set
        {
            if (value.Length < 6)
            {
                throw new ArgumentException("Invalid flower store name!");
            }
            this.name = value;
        }
    }
    public int Count { get { return this.flowers.Count; } }
    public void AddFlower(Flower flower)
    {
        this.flowers.Add(flower);
    }
    public double CalculateTotalPrice()
    {
        return this.flowers.Sum(f => f.Price);
    }
    public Flower GetFlowerWithHighestPrice()
    {
        return this.flowers.OrderBy(f => f.Price)
            .LastOrDefault();
    }
    public Flower GetFlowerWithLowestPrice()
    {
        return this.flowers.OrderBy(f => f.Price)
            .FirstOrDefault();
    }
    public void RenameFlowerStore(string newName)
    {
        this.Name = newName;
    }
    public void SellAllFlowers()
    {
        this.flowers.Clear();
    }
    public bool SellFlower(Flower flower)
    {
        Flower remove = this.flowers.FirstOrDefault(f =>
            f.Type == flower.Type
            && f.Color == flower.Color
            && f.Price == flower.Price);
        return this.flowers.Remove(remove);
    }
    public override string ToString()
    {
        if (flowers.Any())
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Flower store {this.Name} has {this.Count} flower/s:");
            foreach (var flower in this.flowers)
            {
                sb.AppendLine(flower.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        return $"Flower store {this.Name} has no available flowers.";
    }
}


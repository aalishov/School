using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Starship starship = new Starship(9, 5, 2, 1);
        Starship attackedStarship = new Starship(27, 3, 4, 2);
        starship.Attack(attackedStarship);
        Console.WriteLine(starship);
        Console.WriteLine();
        Console.WriteLine(attackedStarship);
    }
}
public class Starship
{
    public Starship(double maxSpeed, int level, int x, int y)
    {
        MaxSpeed = maxSpeed;
        Power = 100;
        Level = level;
        X = x;
        Y = y;
        Integrity = 100;
    }

    public double MaxSpeed { get; set; }
    public int Power { get; set; }
    public int Level { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Integrity { get; set; }
    public override string ToString()
    { StringBuilder sb = new();
        sb.AppendLine($"Max Speed: {MaxSpeed}");
        sb.AppendLine($"Power: {Power}");
        sb.AppendLine($"Level: {Level}");
        sb.AppendLine($"X: {X}");
        sb.AppendLine($"Y: {Y}");
        sb.AppendLine($"Integrity: {Integrity}");
        return sb.ToString().TrimEnd();
    }
    public void Attack(Starship starship)
    {
        var result = starship.Level - this.Power;
        if (result<0)
        {
            starship.Integrity += result;
            starship.Level = 0;
        }
    }
}


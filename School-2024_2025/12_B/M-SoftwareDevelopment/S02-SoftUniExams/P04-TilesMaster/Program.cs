using System.Text;

public class Program
{
    private static Queue<int> greyTiles;
    private static Stack<int> whiteTiles;
    static Dictionary<string, int> order = null;
    public static void Main()
    {
        Input();
        Action();
        Output();
    }

    private static void Input()
    {
        order = new Dictionary<string, int>(new List<KeyValuePair<string, int>>()
        {
            new KeyValuePair<string, int>("Floor",0),
            new KeyValuePair<string, int>("Countertop",0),
            new KeyValuePair<string, int>("Oven",0),
            new KeyValuePair<string, int>("Sink",0),
            new KeyValuePair<string, int>("Wall",0),
        });

        whiteTiles = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
        greyTiles = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
    }

    private static void Action()
    {
        while (whiteTiles.Any() && greyTiles.Any())
        {
            int whiteTile = whiteTiles.Pop();
            int greyTile = greyTiles.Dequeue();
            if (whiteTile != greyTile)
            {
                whiteTile /= 2;
                whiteTiles.Push(whiteTile);
                greyTiles.Enqueue(greyTile);
                continue;
            }
            int sum = whiteTile + greyTile;

            if (sum == 40) { order["Sink"]++; }
            else if (sum == 50) { order["Oven"]++; }
            else if (sum == 60) { order["Countertop"]++; }
            else if (sum == 70) { order["Wall"]++; }
            else { order["Floor"]++; }

        }
    }

    private static void Output()
    {
        string white = whiteTiles.Any() ? $"{string.Join(", ", whiteTiles)}" : "none";
        string grey = greyTiles.Any() ? $"{string.Join(", ", greyTiles)}" : "none";

        Console.WriteLine($"White tiles left: {white}");
        Console.WriteLine($"Grey tiles left: {grey}");

        foreach (var item in order.Where(x => x.Value > 0).OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}

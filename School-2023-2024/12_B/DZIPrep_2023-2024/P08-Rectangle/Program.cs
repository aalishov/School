public class Program
{
   public static void Main()
    {
        Rectangle r = new Rectangle(new Point(10, 10), new Point(15, 15));

        Console.WriteLine($" {r.Width} {r.Height} {r.Perimeter} {r.Area}");

        Worker worker = new Worker();
        Console.WriteLine(worker.AllTiles(r, new Tile(4, 4)));
    }
}


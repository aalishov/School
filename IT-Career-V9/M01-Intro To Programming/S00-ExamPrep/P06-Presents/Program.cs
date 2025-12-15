public class Program
{
    public static void Main()
    {
        int children = int.Parse(Console.ReadLine());

        int lego = 0;
        int monopoly = 0;
        int puzzles = 0;
        int robots = 0;

        for (int i = 0; i < children; i++)
        {
            string present = Console.ReadLine();
            switch (present)
            {
                case "lego": lego++; break;
                case "monopoly": monopoly++; break;
                case "puzzle": puzzles++; break;
                case "robot": robots++; break;
            }
        }

        Console.WriteLine($"Lego: {lego/(double)children*100.0:f2}%");
        Console.WriteLine($"Monopoly: {monopoly / (double)children * 100.0:f2}%");
        Console.WriteLine($"Puzzles: {puzzles / (double)children * 100.0:f2}%");
        Console.WriteLine($"Robots: {robots / (double)children * 100.0:f2}%");
    }
}


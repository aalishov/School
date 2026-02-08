public class Program
{
    public static void Main()
    {
        int tournaments = int.Parse(Console.ReadLine());
        int startPoints = int.Parse(Console.ReadLine());
        int tournamentsPoints = 0;
        int wins = 0;

        for (int i = 0; i < tournaments; i++)
        {
            string stage = Console.ReadLine();
            switch (stage)
            {
                case "W": tournamentsPoints += 2000; wins++; break;
                case "F": tournamentsPoints += 1200; break;
                case "SF": tournamentsPoints += 720; break;
            }
        }

        int totalPoints = startPoints + tournamentsPoints;
        int averagePoints = (int)Math.Floor(tournamentsPoints / (double)tournaments);
        double percentage = wins / (double)tournaments * 100.0;

        Console.WriteLine($"Final points: {totalPoints}");
        Console.WriteLine($"Average points: {averagePoints}");
        Console.WriteLine($"{percentage:f2}%");
    }
}


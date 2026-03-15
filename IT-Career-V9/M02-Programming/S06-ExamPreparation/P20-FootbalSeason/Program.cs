public class Program
{
    private static SortedDictionary<string, int> teamPoints = new SortedDictionary<string, int>();
    public static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine()!;
            if (input == "End of season") { break; }

            string[] info = input.Split(" - ");
            string name = info[0];
            int gols = int.Parse(info[1]);

            if (!teamPoints.ContainsKey(name))
            {
                teamPoints.Add(name, 0);
            }
            teamPoints[name] += gols;
        }
        foreach (var player in teamPoints)
        {
            Console.WriteLine($"{player.Key} -> {player.Value}");
        }
    }
}
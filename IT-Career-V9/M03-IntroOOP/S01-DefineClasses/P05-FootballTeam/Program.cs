public class Program
{
    private readonly static Dictionary<string, Team> teams = new Dictionary<string, Team>();

    public static void Main()
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            if (input[0] == "END")
            {
                break;
            }
            else if (input[0] == "Team")
            {
                try
                {
                    Team team = new Team(input[1]);
                    teams.Add(input[1], team);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (input[0] == "Add")
            {
                try
                {
                    Player player = new Player(input[2], int.Parse(input[3]), int.Parse(input[4]), int.Parse(input[5]), int.Parse(input[6]), int.Parse(input[7]));
                    teams[input[1]].AddPlayer(player);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (input[0] == "Remove")
            {
                try
                {
                    Console.WriteLine(teams[input[1]].RemovePlayer(input[2]));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (input[0] == "Rating")
            {
                try
                {
                    Console.WriteLine($"{input[1]} - {teams[input[1]].Rating}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
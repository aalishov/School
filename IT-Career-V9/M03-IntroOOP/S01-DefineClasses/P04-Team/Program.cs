
public class Program
{
    private static readonly Team team = new Team("Dream Team");
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstName = input[0];
            string lastName = input[1];
            int age = int.Parse(input[2]);
            double salary = double.Parse(input[3]);
            Person person = new Person(firstName, lastName, age, salary);
            team.AddPlayer(person);
        }

        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {team.SecondTeam.Count} players");
    }
}


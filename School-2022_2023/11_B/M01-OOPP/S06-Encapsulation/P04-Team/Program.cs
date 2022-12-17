using System;

public class Program
{
    static void Main()
    {
        Team team = new Team("SoftUni");

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] info = Console.ReadLine().Split(' ');
            try
            {
                team.Add(new Person(info[0], info[1], int.Parse(info[2]), decimal.Parse(info[3])));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

        Console.WriteLine(team);
    }
}


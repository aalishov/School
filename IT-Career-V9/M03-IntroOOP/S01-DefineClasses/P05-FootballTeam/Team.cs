public class Team
{
    private readonly List<Player> players;

    public Team(string name)
    {
        Name = name;
        players = new List<Player>();
    }

    public string Name { get; private set; }

    public double Rating
    {
        get
        {
            if (players.Any())
            {
                return players.Average(x => x.Rating);
            }
            else
            {
                return 0;
            }
        }
    }

    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    public string RemovePlayer(string playerName)
    {
        var player = players.FirstOrDefault(x => x.Name == playerName);
        if (player == null)
        {
            return $"Player {playerName} is not in {Name} team.";
        }
        players.Remove(player);
        return $"Player {playerName} has been removed from {Name} team.";
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private readonly List<Player> players;

        public Team(string name, int openPositions, char group)
        {
            this.Name = name;
            this.OpenPositions = openPositions;
            this.Group = group;
            this.players = new List<Player>();
        }
        public string Name { get; private set; }
        public int OpenPositions { get; private set; }
        public char Group { get; private set; }
        public int Count { get => this.players.Count; }
        public IReadOnlyCollection<Player> Players => this.players;
        public string AddPlayer(Player player)
        {
            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            if (this.OpenPositions <= 0)
            {
                return "There are no more open positions.";
            }
            if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }
            this.players.Add(player);
            this.OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {this.OpenPositions}.";
        }
        public bool RemovePlayer(string name)
        {
            Player player = this.players.FirstOrDefault(x => x.Name == name);
            bool isRemoved = this.players.Remove(player);

            if (isRemoved) { OpenPositions++; }
            return isRemoved;
        }
        public int RemovePlayerByPosition(string position)
        {
            int removed = this.players.RemoveAll(x => x.Position == position);
            this.OpenPositions += removed;
            return removed;
        }
        public Player RetirePlayer(string name)
        {
            Player player = this.players.FirstOrDefault(x => x.Name == name);
            if (player != null) { player.Retired = true; }
            return player;
        }
        public List<Player> AwardPlayers(int games)
        {
            return this.players.Where(x => x.Games > games).ToList();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:");
            foreach (var player in this.players.Where(x=>x.Retired==false))
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}

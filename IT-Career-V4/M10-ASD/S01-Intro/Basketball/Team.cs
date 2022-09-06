using System;
using System.Collections.Generic;
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
        }
        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }
        public int Count { get => players.Count; }
    }
}

﻿using System;
using System.Text;

namespace Basketball
{
    public class Player
    {
        public Player(string name, string position, double rating, int games)
        {
            this.Name = name;
            this.Position = position;
            this.Rating = rating;
            this.Games = games;
            this.Retired = false;
        }

        public string Name { get; private set; }
        public string Position { get; private set; }
        public double Rating { get; private set; }
        public int Games { get; private set; }
        public bool Retired { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-Player: {this.Name}");
            sb.AppendLine("--Position: {this.Position}");
            sb.AppendLine("--Rating: {this.Rating}");
            sb.AppendLine("--Games played: {this.Games}");
            return sb.ToString().TrimEnd();
        }
    }
}

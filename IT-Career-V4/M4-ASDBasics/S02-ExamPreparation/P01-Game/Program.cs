namespace P01_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static Dictionary<string, Player> players = new Dictionary<string, Player>();
        private static int capacity;
        private static string[] input;
        public static void Main()
        {
            capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                input = Console.ReadLine().Split(' ');

                string cmd = input[0].ToLower();

                if (cmd == "end") { break; }
                else if (cmd == "dice") { Dice(); }
                else if (cmd == "currentstate") { CurrentState(); }
                else if (cmd == "currentpairsum") { CurrentPairSum(); }
                else if (cmd == "winner") { Winner(); }
                else if (cmd == "currentstanding") { CurrentStanding(); }
            }
        }

        private static void Winner()
        {
            Player winner = players.OrderBy(x => x.Value.GetPoints()).FirstOrDefault().Value;
            int winnerPoints = winner.GetPoints();
            if (players.Where(x => x.Value.GetPoints() == winnerPoints).Count() == 1)
            {
                Console.WriteLine($"{winner.Name} wins the game!");
            }
            else
            {
                Console.WriteLine("No winner!");
            }
        }

        private static void CurrentStanding()
        {
            Dictionary<string, Player> ranking = players.OrderBy(x => x.Value.BestPairPoints()).ToDictionary(x => x.Key, x => x.Value);
            foreach (var player in ranking)
            {
                Console.WriteLine($"{player.Value.Name} - {player.Value.BestPair()}");
            }
        }

        private static void CurrentPairSum()
        {
            string name = input[1];
            if (players.ContainsKey(name))
            {
                Console.WriteLine(players[name].CurrentPairSum());
            }
        }

        private static void CurrentState()
        {
            string name = input[1];
            if (players.ContainsKey(name))
            {
                Console.WriteLine(players[name].CurrentState());
            }
            else
            {
                Console.WriteLine("Players not found!");
            }
        }

        private static void Dice()
        {
            string name = input[1];
            if (!players.ContainsKey(name))
            {
                players.Add(name, new Player(name));
            }

            int first = int.Parse(input[2]);
            int second = int.Parse(input[3]);
            players[name].Dice(first, second, capacity);
        }
    }
}

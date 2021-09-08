using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_Game
{
    public class Player
    {
        private List<Pair> pairs;

        public Player(string name)
        {
            Name = name;
            this.pairs = new List<Pair>();
        }

        public string Name { get; set; }

        public void Dice(int first, int second, int capacity)
        {
            Pair pair = new Pair(first, second);
            if (pairs.Count(x => x.IsSpecial) == capacity)
            {

            }
            else if (pairs.Count == capacity)
            {
                int firstSpecial = pairs.Where(x => x.IsSpecial == false).Sum(x => x.First);
                int secondSpecial = pairs.Where(x => x.IsSpecial == false).Sum(x => x.Second);

                Pair specialPair = new Pair(firstSpecial, secondSpecial, true);
                this.pairs.RemoveAll(x => x.IsSpecial == false);
                this.pairs.Add(specialPair);
                this.pairs.Add(pair);
            }
            else
            {
                this.pairs.Add(pair);
            }

            
        }

        public string CurrentPairSum()
        {
            int first = pairs.Where(x => x.IsSpecial == true).Sum(x => x.First);
            int second = pairs.Where(x => x.IsSpecial == true).Sum(x => x.Second);

            return $"({first}, {second})";
        }

        public string CurrentState()
        {
            StringBuilder sb = new StringBuilder();
            pairs.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }

        public int GetPoints()
        {
            int first = pairs.Where(x => x.IsSpecial == true).Sum(x => x.First);
            int second = pairs.Where(x => x.IsSpecial == true).Sum(x => x.Second);
            return Math.Abs(first - second);
        }

        public Pair BestPair()
        {
            return this.pairs.Where(x=>x.IsSpecial).OrderBy(x => Math.Abs(x.First - x.Second)).FirstOrDefault();
        }

        public int BestPairPoints()
        {
            return Math.Abs(BestPair().First - BestPair().Second);
        }
    }
}

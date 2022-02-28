using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_FishingNet
{
    public class Net
    {
        private readonly ICollection<Fish> fish;

        public Net(string material, int capacity)
        {
            this.Material = material;
            this.Capacity = capacity;
            this.fish = new List<Fish>();
        }

        public string Material { get; private set; }
        public int Capacity { get; private set; }
        public int Count { get { return this.fish.Count; } }

        public string AddFish(Fish fish)
        {
            if (this.Count < this.Capacity)
            {
                this.fish.Add(fish);
                return $"Successfully added {fish.FishType} to the fishing net.";
            }
            return $"Fishing net is full.";
        }

        public bool ReleaseFish(double weight)
        {
            return this.fish.Remove(this.fish.FirstOrDefault(x => x.Weight == weight));
        }

        public Fish GetFish(string fishType)
        {
            return this.fish.FirstOrDefault(x => x.FishType == fishType);
        }

        public Fish GetBiggestFish()
        {
            return this.fish.OrderByDescending(x => x.Length)
                .FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {this.Material}");
            foreach (var f in this.fish)
            {
                sb.AppendLine(f.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}

using System;

namespace P03_FishingNet
{
    public class Fish
    {
        private string fishType;

        public Fish(string fishType, double length, double weight)
        {
            this.FishType = fishType;
            this.Length = length;
            this.Weight = weight;
        }

        public string FishType
        {
            get { return this.fishType; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Error: {nameof(this.FishType)}");
                }
                this.fishType = value;
            }
        }
        public double Length { get; private set; }
        public double Weight { get; private set; }

        public override string ToString()
        {
            return $"There is a {this.FishType}, {this.Length} cm. long, and {this.Weight} gr. in weight.";
        }
    }
}

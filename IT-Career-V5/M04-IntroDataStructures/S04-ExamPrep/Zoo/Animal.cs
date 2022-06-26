namespace Zoo
{
    public class Animal
    {
        public Animal(string species, string diet, double weight, double length)
        {
            this.Species = species;
            this.Diet = diet;
            this.Weight = weight;
            this.Length = length;
        }
        public string Species { get; private set; }
        public string Diet { get; private set; }
        public double Weight { get; private set; }
        public double Length { get; private set; }
        public override string ToString()
        {
            return $"The {this.Species} is a {this.Diet} and weighs {this.Weight} kg.";
        }
    }
}

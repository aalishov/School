namespace P05_Farm
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}

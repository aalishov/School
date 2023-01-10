
public class Dog : Mammal
{
    public Dog(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
    {
    }

    public override string MakeNoise()
    {
        return "Woof!";
    }
    public override string ToString()
    {
        return $"{GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}


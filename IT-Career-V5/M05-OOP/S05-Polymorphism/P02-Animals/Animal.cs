namespace Animals
{
    public class Animal
    {
        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }
        public string Name { get; private set; }
        public string FavouriteFood { get; private set; }
        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        }
    }
}

namespace P02_Animals
{
    public class Animal
    {
        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public string Name { get; set; }

        public string FavouriteFood { get; set; }

        public virtual string ExplainMySelf ()
        {
            return $"I am {this.Name} and my fovourite food is { this.FavouriteFood}";
        }
    }
}

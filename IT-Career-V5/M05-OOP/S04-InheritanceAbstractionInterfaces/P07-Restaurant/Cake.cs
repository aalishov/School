namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double InitialGrams = 250;
        private const double InitialCalories = 1000;
        private const decimal InitialPrice = 5;
        public Cake(string name) : base(name, InitialPrice, InitialGrams, InitialCalories)
        {
        }
    }
}

namespace P05_Farm
{
    public abstract class Animal
    {
        private string animalName;

        public string AnimalName { get => animalName; set => animalName = value; }

        public string AnimalType { get; set; }

        public double AnimalWeight { get; set; }

        public int FoodEaten { get; set; }

        public abstract string MakeSound();

        public abstract string Eat(Food food);
    }
}

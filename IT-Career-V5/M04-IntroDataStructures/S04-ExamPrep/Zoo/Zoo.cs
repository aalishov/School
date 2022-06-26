namespace Zoo
{
    using System.Collections.Generic;
    using System.Linq;

    public class Zoo
    {
        private readonly List<Animal> animals;
        public Zoo(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.animals = new List<Animal>();
        }
        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return $"Invalid animal species.";
            }
            if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return $"Invalid animal diet.";
            }
            if (this.animals.Count >= this.Capacity)
            {
                return $"The zoo is full.";
            }
            this.animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }
        public int RemoveAnimals(string species)
        {
            return this.animals.RemoveAll(x => x.Species == species);
        }
        public List<Animal> GetAnimalsByDiet(string diet)
        {
            return this.animals.Where(x => x.Diet == diet).ToList();
        }
        public Animal GetAnimalByWeight(double weight)
        {
            return this.animals.FirstOrDefault(x => x.Weight == weight);
        }
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = this.animals.Count(x => x.Length >= minimumLength && x.Length <= maximumLength);
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}

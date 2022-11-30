using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {

        private readonly List<Animal> animals = new List<Animal>();
        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species.";
            }
            if (animal.Diet != "herbivore" && animal.Diet != "herbivore")
            {
                return "Invalid animal diet.";
            }
            if (this.Capacity <= animals.Count)
            {
                return "The zoo is full.";
            }
            animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }
        public int RemoveAnimals(string species)
        {
            return animals.RemoveAll(x => x.Species == species);
        }
        public List<Animal> GetAnimalsByDiet(string diet)
        {
            return this.animals.Where(x => x.Diet == diet).ToList();
        }
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = this.animals.Count(x => x.Length >= minimumLength && x.Length <= maximumLength);
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
        public List<Animal> Sort()
        {
            return this.animals.OrderBy(x => x.Weight).ThenBy(x => x.Length).ThenBy(x => x.Diet).ThenBy(x => x.Species).ToList();
        }
    }
}

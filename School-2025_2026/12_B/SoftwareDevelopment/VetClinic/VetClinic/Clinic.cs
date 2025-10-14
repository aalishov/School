using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            pets = new List<Pet>();
        }

        public int Capacity { get; private set; }

        public int Count { get { return pets.Count; } }

        public void Add(Pet pet)
        {
            if (Capacity == Count) { return; }
            pets.Add(pet);
        }

        public bool Remove(string name)
        {
            return pets.Remove(pets.FirstOrDefault(p => p.Name == name));
        }

        public Pet GetPet(string name, string owner)
        {
            return pets.FirstOrDefault(x => x.Name == name && x.Owner == owner);
        }

        public Pet GetOldestPet()
        {
            return pets.OrderByDescending(x => x.Owner).FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The clinic has the following patients:");
            foreach (Pet pet in pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
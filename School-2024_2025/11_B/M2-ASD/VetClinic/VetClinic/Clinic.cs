using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private readonly List<Pet> pets;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            pets = new List<Pet>();
        }

        public int Capacity { get; private set; }

        public void Add(Pet pet)
        {
            if (pets.Count < Capacity)
            {
                pets.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            Pet? pet = pets.FirstOrDefault(x => x.Name == name);
            return pets.Remove(pet);
        }

        public Pet? GetPet(string name, string owner)
        {
            return pets.FirstOrDefault(x => x.Name == name && x.Owner == owner);
        }

        public Pet? GetOldestPet()
        {
            return pets.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (Pet pet in pets)
            {
                sb.AppendLine(pet.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets;

        public Clinic(int capacity)
        {
            this.pets = new List<Pet>();
            this.Capacity = capacity;
        }

        public int Capacity { get; set; }

        public void Add(Pet pet)
        {
            if (this.pets.Count < this.Capacity)
            {
                this.pets.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet removeThisPet = this.pets.FirstOrDefault(x => x.Name == name);
            return this.pets.Remove(removeThisPet);
        }

        public Pet GetPet(string name, string owner)
        {
            return this.pets.FirstOrDefault(x => x.Name == name && x.Owner == owner);
        }

        public Pet GetOldestPet()
        {
            return this.pets.OrderBy(x => x.Age).LastOrDefault();
        }

        public int Count { get => this.pets.Count; }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The clinic has the following patients:");

            foreach (var pet in this.pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}

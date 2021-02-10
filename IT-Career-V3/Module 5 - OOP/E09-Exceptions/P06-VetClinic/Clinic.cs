using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace P06_VetClinic
{
    public class Clinic
    {
        private readonly List<Pet> pets;

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.pets = new List<Pet>();
        }

        public int Capacity { get; private set; }

        public int Count { get => this.pets.Count; }

        public void Add(Pet pet)
        {
            if (this.pets.Count < this.Capacity)
            {
                this.pets.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet find = pets.FirstOrDefault(x => x.Name == name);

            //TODO: Check later Clinic Remove Method
            return pets.Remove(find);
        }

        public Pet GetPet(string name, string owner)
        {
            return pets.FirstOrDefault(x => x.Name == name && x.Owner == owner);
        }

        public Pet GetOldestPet()
        {
            return pets.OrderBy(x => x.Age).LastOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in pets)
            {
                sb.AppendLine($"{pet.Name} {pet.Owner}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
        private readonly List<Drink> drinks;

        public VendingMachine(int buttonCapacity)
        {
            ButtonCapacity = buttonCapacity;
            drinks = new List<Drink>();
        }

        public int ButtonCapacity { get; private set; }

        public IReadOnlyCollection<Drink> Drinks { get { return drinks; } }

        public int GetCount { get { return drinks.Count; } }

        public void AddDrink(Drink drink)
        {
            if (drinks.Count < ButtonCapacity)
            {
                drinks.Add(drink);
            }
        }

        public bool RemoveDrink(string name)
        {
            Drink drinkToRemove = drinks.FirstOrDefault(d => d.Name == name);
            return drinks.Remove(drinkToRemove);
        }

        public Drink GetLongest()
        {
            return drinks.OrderByDescending(d => d.Volume).FirstOrDefault();
        }

        public Drink GetCheapest()
        {
            return drinks.OrderBy(d => d.Price).FirstOrDefault();
        }

        public string BuyDrink(string name)
        {
            return drinks.FirstOrDefault(d => d.Name == name).ToString();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Drinks available:");
            drinks.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}

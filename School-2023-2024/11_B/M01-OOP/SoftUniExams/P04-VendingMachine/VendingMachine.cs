using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_VendingMachine
{
    public class VendingMachine
    {
        private List<Drink> drinks=new List<Drink>();

        public VendingMachine(int buttonCapacity)
        {
            ButtonCapacity = buttonCapacity;
        }

        public int ButtonCapacity { get; private set; }
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
            Drink drink = drinks.FirstOrDefault(x => x.Name == name);

            return drinks.Remove(drink);

        }
        public Drink GetLongest() 
        {
            Drink drink=drinks.OrderBy(x => x.Volume).LastOrDefault();
            return drink;
        }
        public Drink GetCheapest()
        {
            Drink drink=drinks.OrderBy(drink=> drink.Price).FirstOrDefault();
            return drink;
        }

        public string BuyDrink(string name)
        {
            Drink drink = drinks.FirstOrDefault(x => x.Name == name);
            return drink.ToString();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Drinks available: ");
            foreach (var m in drinks)
            {
                sb.AppendLine(m.ToString());
            }
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Animals
{
    public abstract class Animal
    {
        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }
        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        public abstract string Play();
        public virtual string ExplainMyself()
        {
            return $"I'm animal!";
        }
    }
}

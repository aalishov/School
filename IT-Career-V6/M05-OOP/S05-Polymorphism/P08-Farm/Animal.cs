using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_Farm
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }

        public double AnimalWeight { get; set; }

        public int FoodEaten { get; set; }

        public abstract string MakeSound();

        public abstract string Eat(Food food);


    }
}

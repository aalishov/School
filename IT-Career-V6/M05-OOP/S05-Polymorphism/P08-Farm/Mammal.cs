using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_Farm
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        public override string Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
            return $"{this.GetType().Name} eating {food.GetType().Name}{{{food.Quantity}}}";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}

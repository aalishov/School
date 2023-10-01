using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_Farm
{
    public class Cat : Felime
    {
        public string Breed { get; set; }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{AnimalName}, {Breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]"; ;
        }
    }
}

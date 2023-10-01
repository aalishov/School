using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_Farm
{
    public class Mouse : Mammal
    {
        public override string MakeSound()
        {
            return "SQUEEEAAAK!";
        }

        public override string Eat(Food food)
        {
            if (food.GetType().Name==nameof(Meat))
            {
                return $"{GetType().Name} are not eating that type of food!";
            }
            return base.Eat(food);
        }
    }
}

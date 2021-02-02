using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Farm
{
    public class Mouse : Mammal
    {
        public override string Eat(Food food)
        {
            throw new NotImplementedException();
        }

        public override string MakeSound()
        {
            return "SQUEEEAAAK!";
        }
    }
}

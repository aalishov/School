using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            return $"I'm dog! Barking...";
        }

        public override string Play()
        {
            throw new NotImplementedException();
        }
    }
}

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

        public override string MakeNoise()
        {
            return base.MakeNoise()+ "Woof!";
        }

        public override string MakeTrick()
        {
            return base.MakeTrick()+ "Hold my paw, human!";
        }
    }
}

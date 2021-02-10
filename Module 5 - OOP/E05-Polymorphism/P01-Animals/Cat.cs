using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + " I'm cat too...";
        }

        public override string Play()
        {
            return $"Cat play!";
        }

        public override string MakeNoise()
        {
            return base.MakeNoise() + "Meow!.";
        }

        public override string MakeTrick()
        {
            return base.MakeTrick() + "No trick for you! I'm too lazy!";
        }
    }
}

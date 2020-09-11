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
    }
}

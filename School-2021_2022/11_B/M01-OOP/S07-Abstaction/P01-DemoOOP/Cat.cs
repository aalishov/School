using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_DemoOOP
{
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public string Meow()
        {
            return "Meowing...";
        }

        public override string ToString()
        {
            return base.ToString() +$", {Meow()}";
        }
    }
}

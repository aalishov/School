using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_DemoOOP
{
    public class Cat : Animal,IPlay
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine(Meow());
        }

        public string Meow()
        {
            return "Meowing...";
        }

        public void Play()
        {
            Console.WriteLine($"{GetType().Name} playing..");
        }

        public override string ToString()
        {
            return base.ToString() +$", {Meow()}";
        }
    }
}

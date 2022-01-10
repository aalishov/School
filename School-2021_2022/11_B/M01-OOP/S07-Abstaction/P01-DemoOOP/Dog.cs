using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_DemoOOP
{
    public class Dog : Animal ,IPlay
    {
        public Dog(string name,string breed) : base(name, 1)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public string Bark()
        {
            return "Barking....";
        }

        public override void MakeNoise()
        {
            Console.WriteLine(Bark());
        }

        public void Play()
        {
            Console.WriteLine($"{GetType().Name} playing with ball...");
        }

        public override string ToString()
        {
            return base.ToString() + $", {nameof(this.Breed)}: {this.Breed}, {this.Bark()}";
        }
    }
}

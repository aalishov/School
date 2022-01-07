using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_DemoOOP
{
    public class Dog : Animal 
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

        public override string ToString()
        {
            return base.ToString() + $", {nameof(this.Breed)}: {this.Breed}, {this.Bark()}";
        }
    }
}

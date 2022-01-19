using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoPolymorphism
{
    public class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{GetType().Name} is flying...");
        }
    }
}

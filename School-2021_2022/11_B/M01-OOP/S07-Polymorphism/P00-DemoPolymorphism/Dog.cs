using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoPolymorphism
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{this.GetType().Name} is mooving...");
        }
    }
}

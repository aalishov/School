using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoPolymorphism
{
    public class Fish : Animal
    {
        public Fish(string name, int age) : base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{this.GetType().Name} is swiming...");
        }

        public override void Breathe()
        {
            Console.WriteLine($"{this.GetType().Name} - breathe in water");
        }
    }
}

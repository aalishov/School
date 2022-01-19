using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoPolymorphism
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public virtual void Breathe()
        {
            Console.WriteLine($"{this.GetType().Name} - breathe");
        }
        public abstract void Move();


    }
}

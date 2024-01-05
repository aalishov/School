using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_Demo
{
    public abstract class Animal
    {
        private int age;

        protected Animal(int age)
        {
            Age = age;
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException($"Invalid {nameof(Age)}");
                }
                this.age = value;
            }
        }
    }
}

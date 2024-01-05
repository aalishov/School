using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad28
{
    public abstract class Person
    {
        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }
    }
}

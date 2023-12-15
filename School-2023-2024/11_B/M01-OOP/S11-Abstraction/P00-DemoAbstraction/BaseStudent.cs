using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoAbstraction
{
    public abstract class BaseStudent
    {

        protected BaseStudent(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; protected set; }
        public abstract void PrintName();

        public abstract void ChangeAge(int age);

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

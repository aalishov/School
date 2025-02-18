using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    internal class Child : Person
    {
        public Person Mother { get; set; }
        public Person Father { get; set; }
        public Child(string name, int age,Person mother,Person father) : base(name, age)
        {
            this.Mother = mother;
            this.Father = father;
        }
        public override string ToString()
        {
            return base.ToString() + $" Mother: {this.Mother.Name}.Father: {this.Father.Name}";
        }
    }
}

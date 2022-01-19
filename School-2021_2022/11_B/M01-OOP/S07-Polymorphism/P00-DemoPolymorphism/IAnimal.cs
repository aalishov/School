using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoPolymorphism
{
    interface IAnimal : IMove
    {
        public string Name { get;  }
        public int Age { get; }
        public void Breathe();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_Demo
{
    public class Mammal : Animal, IPrintable
    {
        public Mammal(int age) : base(age)
        {
        }

        public virtual string Color { get; set; }

        public virtual string Print()
        {
            return $"Print method - mammal";
        }
    }
}

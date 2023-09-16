using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_SandBox
{
    public abstract  class Shape
    {
        public abstract double Area();

        public virtual string ExplainMyself()
        {
            return "I'm shape";
        }
    }
}

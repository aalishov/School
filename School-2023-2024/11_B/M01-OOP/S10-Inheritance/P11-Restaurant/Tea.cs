using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Restaurant
{
    public class Tea : HotBeverage
    {
        public Tea(string name, decimal price, double mililitres) : base(name, price, mililitres)
        {
        }
    }
}

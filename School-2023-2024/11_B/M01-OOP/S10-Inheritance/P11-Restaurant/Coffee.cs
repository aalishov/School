using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Restaurant
{
    public class Coffee : HotBeverage
    {
        private static double CoffeeMilliliters = 50;
        private static decimal CoffeePrice = 3.50m;
        public Coffee(string name, double caffeine) : base(name, CoffeePrice, CoffeeMilliliters)
        {
            Caffeine = caffeine;
        }
        public double Caffeine { get; private set; }
    }
}

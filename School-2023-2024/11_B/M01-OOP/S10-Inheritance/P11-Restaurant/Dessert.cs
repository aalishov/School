using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Restaurant
{
    public class Dessert : Food
    {
        protected Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            Calories = calories;
        }
        public double Calories { get; set; }
    }
}

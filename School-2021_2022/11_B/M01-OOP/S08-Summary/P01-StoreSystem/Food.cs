using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StoreSystem
{
    public class Food : Product
    {
        public Food(string name, int quantity, double deliverPrice, double percentageMarkup) : base(name, quantity, deliverPrice, percentageMarkup)
        {
        }

        public override double PercentageMarkup
        {
            get { return base.PercentageMarkup; }
            set
            {
                base.PercentageMarkup = value;
                if (value>100)
                {
                    throw new ArgumentException("Food percentage markup cannot be above 100%!");
                }
            }
        }
    }
}

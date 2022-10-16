using System;
using System.Collections.Generic;
using System.Text;

public class Drink : Product
{
    public Drink(string name, int quantity, double deliverPrice, double percentageMarkup) : base(name, quantity, deliverPrice, percentageMarkup)
    {
    }
    public override double PercentageMarkup
    {
        get { return base.PercentageMarkup; }
        protected set
        {
            if (value > 200)
            {
                throw new ArgumentException("Drink percentage markup cannot be above 200%!");
            }
            base.PercentageMarkup = value;
        }
    }
}


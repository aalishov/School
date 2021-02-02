namespace P01_StoreSystem
{
    using System;

    public class Food : Product
    {
        public Food(string name, int quantity, double deliverPrice, double percentageMarkup)
            : base(name, quantity, deliverPrice, percentageMarkup)
        {
        }

        public override double PercentageMarkup
        {
            get
            {
                return base.PercentageMarkup;
            }

            set
            {
                base.PercentageMarkup = value;

                if (value > 100)
                {
                    throw new ArgumentException("Foob percentage markup cannot be above 100%!");
                }
            }
        }
    }
}

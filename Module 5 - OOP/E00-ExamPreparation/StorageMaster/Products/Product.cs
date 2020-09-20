namespace StorageMaster.Products
{
    using System;
    public abstract class Product
    {
        private double price;

        protected Product(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value<0)
                {
                    throw new InvalidOperationException("Price cannot be negative!");
                }
                price = value;
            }
        }
        //TODO: Product Weight Validation!!!
        public double Weight { get; set; }

    }
}

using System;

namespace Ex08_OnlineStore
{
    public class Product
    {
        private string name;
        private double price;

        public Product(string name, double price, bool isOnPromotion)
        {
            this.Name = name;
            this.Price = price;
            this.IsOnPromotion = isOnPromotion;
        }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
            this.IsOnPromotion = false;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid product name!");
                }
                name = value;
            }
        }
        public double Price
        {
            get => price; set
            {
                if (value<0)
                {
                    throw new ArgumentException("Price should be positive!");
                }
                price = value;
            }
        }
        public bool IsOnPromotion { get; set; }

        public override string ToString()
        {
            string yesOrNo = IsOnPromotion ? "YES" : "NO";
            return $"Product -> {this.Name} with price {this.Price}. On promotion {yesOrNo}";
        }
    }
}

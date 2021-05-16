namespace Exam_Pharmacy
{
    using System;
    public class Medicine
    {
        private string name;

        private double price;

        public Medicine(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price");
                }
                price = value;
            }
        }
        public override string ToString()
        {
            return $"Medicine: {this.Name} with price {this.Price:f2}";
        }
    }

}
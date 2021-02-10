namespace P01_StoreSystem
{
    using System;
    using System.Text;

    public abstract class Product
    {
        private string name;
        private int quantity;
        private double deliverPrice;
        private double percentageMarkup;

        protected Product(string name, int quantity, double deliverPrice, double percentageMarkup)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.DeliverPrice = deliverPrice;
            this.PercentageMarkup = percentageMarkup;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product name must not be null or empty!");
                }

                this.name = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Quantity cannot be less or equal to 0!");
                }

                this.quantity = value;
            }
        }

        public double DeliverPrice
        {
            get
            {
                return this.deliverPrice;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Deliver price cannot be less or equal to 0!");
                }

                this.deliverPrice = value;
            }
        }

        public virtual double PercentageMarkup
        {
            get
            {
                return this.percentageMarkup;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Percentage markup cannot be less or equal to 0!");
                }

                this.percentageMarkup = value;
            }
        }

        public double FinalPrice { get => this.DeliverPrice + (this.DeliverPrice * this.PercentageMarkup / 100.0); }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"****Product: {this.Name} <{this.Quantity}>");
            sb.AppendLine($"****Deliver Price: {this.DeliverPrice}");
            sb.AppendLine($"****Percentage Markup: {this.PercentageMarkup}");
            sb.AppendLine($"****Final Price: {this.FinalPrice}");

            return sb.ToString().TrimEnd();
        }
    }
}

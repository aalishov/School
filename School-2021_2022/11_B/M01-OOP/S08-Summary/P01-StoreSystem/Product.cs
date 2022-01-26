using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StoreSystem
{
    public abstract class Product
    {
        private string name;
        private int quantity;
        private double deliverPrice;
        private double percentageMarkup;

        protected Product(string name, int quantity, double deliverPrice, double percentageMarkup)
        {
            Name = name;
            Quantity = quantity;
            DeliverPrice = deliverPrice;
            PercentageMarkup = percentageMarkup;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product name must not be null or empty!");
                }
                name = value;
            }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Quantity cannot be less or equal to 0!");
                }
                quantity = value;
            }
        }
        public double DeliverPrice
        {
            get { return deliverPrice; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Deliver price cannot be less or equal to 0!");
                }
                deliverPrice = value;
            }
        }
        public virtual double PercentageMarkup
        {
            get { return percentageMarkup; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Percentage markup cannot be less or equal to 0!");
                }
                percentageMarkup = value;
            }
        }
        public double FinalPrice
        {
            get { return DeliverPrice + (DeliverPrice * PercentageMarkup / 100); }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"****Product: { Name} <{ Quantity}>");
            sb.AppendLine($"****Deliver Price: { DeliverPrice}");
            sb.AppendLine($"****Percentage Markup: { PercentageMarkup}");
            sb.AppendLine($"****Final Price: { FinalPrice}");
            return sb.ToString().TrimEnd();
        }
    }
}
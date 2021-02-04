namespace BrokerCompany.Models
{
    using System;
    using System.Text;
    using BrokerCompany.Common;

    public abstract class Building
    {
        private string name;
        private string city;
        private int stars;
        private double rentAmount;

        protected Building(string name, string city, int stars, double rentAmount)
        {
            this.Name = name;
            this.City = city;
            this.Stars = stars;
            this.RentAmount = rentAmount;
        }

        public virtual string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(StaticMessages.BuildingInvalidNameValue);
                }

                this.name = value;
            }
        }

        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(StaticMessages.BuildingInvalidNameValue);
                }

                this.city = value;
            }
        }

        public int Stars
        {
            get
            {
                return this.stars;
            }

            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException(StaticMessages.BuildingStarsInvalidValue);
                }

                this.stars = value;
            }
        }

        public double RentAmount
        {
            get
            {
                return this.rentAmount;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(StaticMessages.BuildingRentAmaountInvalidValue);
                }

                this.rentAmount = value;
            }
        }

        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(StaticMessages.buildingNameAndStars);
            sb.AppendLine(StaticMessages.buildingLocation);
            sb.AppendLine(StaticMessages.buildingRentAmount);
            sb.AppendLine(StaticMessages.buildingIsAvailable);
            return sb.ToString();
        }
    }
}

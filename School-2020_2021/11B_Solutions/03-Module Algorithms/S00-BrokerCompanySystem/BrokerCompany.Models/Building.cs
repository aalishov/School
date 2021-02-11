namespace BrokerCompany.Models
{
    using System;
    using System.Text;
    using BrokerCompany.Common;

    public abstract class Building : IBuilding
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

            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ModelsSM.InvalidNameValue, nameof(Building)));
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

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ModelsSM.CityInvalidNameValue);
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

            private set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException(ModelsSM.BuildingStarsInvalidValue);
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

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ModelsSM.BuildingRentAmaountInvalidValue);
                }

                this.rentAmount = value;
            }
        }

        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format(ModelsSM.BuildingNameAndStars, this.Name, this.Stars));
            sb.AppendLine(string.Format(ModelsSM.Location, this.City));
            sb.AppendLine(string.Format(ModelsSM.BuildingRentAmount, this.RentAmount));
            sb.AppendLine(string.Format(ModelsSM.BuildingIsAvailable, this.IsAvailable));
            return sb.ToString();
        }
    }
}

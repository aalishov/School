namespace BrokerCompany.Models
{
    using System;
    using BrokerCompany.Common;

    public sealed class Hotel : Building
    {
        public Hotel(string name, string city, int stars, double rentAmount)
            : base(name, city, stars, rentAmount)
        {
        }

        public override string Name
        {
            get
            {
                return base.Name;
            }

            protected set
            {
                base.Name = value;
                if (value.Substring(value.Length - nameof(Hotel).Length, nameof(Hotel).Length) == nameof(Hotel))
                {
                    throw new ArgumentException(string.Format(StaticMessages.HotelInvalidTypeNameValue, nameof(Hotel)));
                }
            }
        }
    }
}

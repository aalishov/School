namespace BrokerCompany.Models
{
    using System;
    using BrokerCompany.Common;

    public sealed class Business : Building
    {
        public Business(string name, string city, int stars, double rentAmount)
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
                if (value.Substring(value.Length - nameof(Business).Length, nameof(Business).Length) == nameof(Business))
                {
                    throw new ArgumentException(string.Format(StaticMessages.HotelInvalidTypeNameValue, nameof(Business)));
                }
            }
        }
    }
}

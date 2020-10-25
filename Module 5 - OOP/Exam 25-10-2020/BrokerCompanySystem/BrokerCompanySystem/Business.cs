using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Business : Building
{
    public Business(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
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
            if (value.Split(' ').Last() != nameof(Business))
            {
                throw new ArgumentException("Name of business buildings should end on Business!");
            }
        }
    }
}


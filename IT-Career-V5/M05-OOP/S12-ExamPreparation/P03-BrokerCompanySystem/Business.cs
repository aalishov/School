using System;
using System.Collections.Generic;
using System.Text;


public class Business : Building
{
    public Business(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
    {
    }

    public override string Name
    {
        get { return base.Name; }
        protected set
        {
            int index = value.Length - (nameof(Business)).Length;
            int result = value.IndexOf(nameof(Business), index);
            if (result == -1)
            {
                throw new ArgumentException("Name of business buildings should end on Business!");
            }
            base.Name = value;
        }
    }
}


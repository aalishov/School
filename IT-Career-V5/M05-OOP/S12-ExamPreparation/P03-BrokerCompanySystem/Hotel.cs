using System;
using System.Collections.Generic;
using System.Text;

public class Hotel : Building
{
    public Hotel(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
    {
    }

    public override string Name
    {
        get { return base.Name; }
        protected set
        {
            int index = value.Length - (nameof(Hotel)).Length;
            int result = value.IndexOf(nameof(Hotel), index);
            if (result == -1)
            {
                throw new ArgumentException("Name of hotel buildings should end on Hotel!");
            }
            base.Name = value;
        }
    }
}


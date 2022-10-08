using System;
using System.Collections.Generic;
using System.Text;

public class Residence : Building
{
    public Residence(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
    {
    }
    public override string Name
    {
        get { return base.Name; }
        protected set
        {
            int index = value.Length - (nameof(Residence)).Length;
            int result = value.IndexOf(nameof(Residence), index);
            if (result == -1)
            {
                throw new ArgumentException("Name of residence buildings should end on Residence!");
            }
            base.Name = value;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

public class Peasant : Person
{
    private int productivity;

    public Peasant(string name, int age, int productivity) : base(name, age)
    {
        this.Productivity = productivity;
    }

    public override int Age
    {
        get { return base.Age; }
        protected set
        {
            if (value > 110)
            {
                throw new ArgumentException("Age cannot be greater than 110!");
            }
            base.Age = value;
        }
    }
    public int Productivity
    {
        get { return productivity; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Productivity cannot be less or equal to 0!");
            }
            productivity = value;
        }
    }
    public override string ToString()
    {
        return base.ToString()+$"{Environment.NewLine}Productivity: {Productivity}";
    }
}


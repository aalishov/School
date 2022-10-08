using System;
using System.Collections.Generic;
using System.Text;

public class PhysicalProduct : Product
{
    private double weight;

    public PhysicalProduct(string name, double price, double weight) : base(name, price)
    {
        this.Weight = weight;
    }
    public double Weight
    {
        get { return weight; }
        private set
        {
            if (value<=0)
            {
                throw new ArgumentException("Weight cannot be less or equal to 0!");
            }
            weight = value;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Weight: {Weight}");
        return sb.ToString().TrimEnd();
    }
}


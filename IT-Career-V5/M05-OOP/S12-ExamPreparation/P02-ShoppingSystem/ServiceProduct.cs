using System;
using System.Collections.Generic;
using System.Text;

public class ServiceProduct : Product
{
    private double time;

    public ServiceProduct(string name, double price,double time) : base(name, price)
    {
        this.Time = time;
    }
    public double Time
    {
        get { return time; }
        private set
        {
            if (value<=0)
            {
                throw new ArgumentException("Time should be greater than 0!");
            }
            time = value;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Time: {Time}");
        return sb.ToString().TrimEnd();
    }
}


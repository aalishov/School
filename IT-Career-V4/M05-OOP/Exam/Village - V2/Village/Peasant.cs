using System;
using System.Collections.Generic;
using System.Text;

namespace Village
{
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
            set
            {
                base.Age = value;
                if (value > 110)
                {
                    throw new ArgumentException("Age cannot be greater than 110!");
                }
            }
        }
        public int Productivity
        {
            get { return productivity; }
            set
            {
                if (value <= 0)
                {
                    throw new NotImplementedException("Productivity cannot be less or equal to 0!");
                }
                productivity = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Productivity: {this.Productivity}");
            return sb.ToString().TrimEnd();
        }
    }


}
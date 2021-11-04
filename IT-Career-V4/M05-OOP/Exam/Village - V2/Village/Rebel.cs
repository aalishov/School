using System;
using System.Text;

namespace Village
{
    public class Rebel : Person
    {
        private int harm;

        public Rebel(string name, int age, int harm) : base(name, age)
        {
            this.Harm = harm;
        }
        public override int Age
        {
            get { return base.Age; }
            set
            {
                base.Age = value;
                if (value > 50)
                {
                    throw new ArgumentException("Age should be less or equal to 50!");
                }
            }
        }
        public int Harm
        {
            get { return harm; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Harm should be greater than 0!");
                }
                harm = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Harm: {this.Harm}");
            return sb.ToString().TrimEnd();
        }
    }
}


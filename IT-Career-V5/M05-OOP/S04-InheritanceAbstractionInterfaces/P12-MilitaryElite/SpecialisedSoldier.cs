using System;

namespace MilitaryElite
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        protected SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }
        public string Corps
        {
            get { return corps; }
            set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException("Invalid corps!");
                }
                corps = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCorps: {this.Corps}";
        }
    }
}

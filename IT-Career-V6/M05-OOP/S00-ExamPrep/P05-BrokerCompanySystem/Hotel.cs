using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_BrokerCompanySystem
{
    public class Hotel : Building
    {
        public Hotel(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
        {
        }
        public override string Name
        {
            get { return base.Name; }
            set
            {
                string cmd = "Hotel";
                if (value.LastIndexOf(cmd) == -1)
                {
                    throw new ArgumentException("Name of hotel buildings should end on Hotel!");
                }
                base.Name = value;
            }
        }
    }
}

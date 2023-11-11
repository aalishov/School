using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P05_BrokerCompanySystem
{
    public class Residence : Building
    {
        public Residence(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
        {
        }
        public override string Name
        {
            get { return base.Name; }
            set
            {
                string cmd = "Residence";
                if (value.LastIndexOf(cmd) == -1)
                {
                    throw new ArgumentException("Name of residence buildings should end on Residence!");
                }
                base.Name = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_CryptoMiningSystem
{
    public class User
    {
        private string name;
        private double money;

        public User(string name, double money)
        {
            Name = name;
            Money = money;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username must not be null or empty!");
                }
                name = value;
            }
        }



        public double Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Username must not be null or empty!");
                }
                money = value;
            }
        }

        public Computer Computer { get; set; }

        public int Stars { get { return (int)Money / 100; } }
    }
}

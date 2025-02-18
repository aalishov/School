using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Cars
{
    public class Renault : ICar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public string Start()
        {
            return "";
        }
        public string Stop()
        {
            return "";
        }
    }
}


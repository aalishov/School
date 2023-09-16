using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Machine
{
    public class Airplane : IMachine
    {
        public Airplane()
        {
            MachineType = nameof(Airplane);
        }

        public string MachineType { get; set; }

        public bool Start()
        {
            Console.WriteLine($"{nameof(Airplane)} starting...");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine($"{nameof(Airplane)} stopping...");
            return true;
        }
    }
}

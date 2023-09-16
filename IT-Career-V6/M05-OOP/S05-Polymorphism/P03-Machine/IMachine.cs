using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Machine
{
    public interface IMachine
    {
        public string MachineType { get; }

        public bool Start();

        public bool Stop();
    }
}

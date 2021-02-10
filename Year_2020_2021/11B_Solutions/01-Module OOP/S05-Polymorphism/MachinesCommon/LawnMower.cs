using System;
using System.Collections.Generic;
using System.Text;

namespace MachinesCommon
{
    public class LawnMower : IMachine
    {
        public LawnMower()
        {
            this.MachineType = this.MachineType = "LawnMower";
        }
        public string MachineType { get; set; }

        public string Start()
        {
            return "LawnMower starting...";
        }

        public string Stop()
        {
            return "LawnMower stopping...";
        }
    }
}

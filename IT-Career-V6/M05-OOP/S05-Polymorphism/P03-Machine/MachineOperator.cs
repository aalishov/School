using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Machine
{
    public class MachineOperator
    {
        private IMachine entity;
        public IMachine Entity
        {
            get { return this.entity; }
            set
            {
                this.entity = value;
                Console.WriteLine("Machine operator is operating: " + value.MachineType);
            }
        }
        public MachineOperator(IMachine entity)
        {
            this.Entity = entity;
        }

        public bool Start()
        {
            return Entity.Start();
        }

        public bool Stop()
        {
            return Entity.Stop();
        }
    }
}

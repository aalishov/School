using System;
using System.Collections.Generic;
using System.Text;

namespace MachinesCommon
{
    public class MachineOperator
    {
        public MachineOperator(IMachine entity)
        {
            this.Entity = entity;
        }

        private IMachine entity;
        public IMachine Entity
        {
            get { return this.entity; }
            set
            {
                this.entity = value;
            }
        }

        public string ChangeMessage()
        {
            return "Machine operator is operating: " + entity.MachineType;
        }

        public string Start()
        {
            return Entity.Start();
        }

        public string Stop()
        {
            return Entity.Stop();
        }


    }
}

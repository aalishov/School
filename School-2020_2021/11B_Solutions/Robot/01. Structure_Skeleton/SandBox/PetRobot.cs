using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox
{
    public class PetRobot : Robot
    {
        public PetRobot(string name, string owner) : base(name)
        {
            this.Owner = owner;
        }
        public string Owner { get; set; }
    }
}

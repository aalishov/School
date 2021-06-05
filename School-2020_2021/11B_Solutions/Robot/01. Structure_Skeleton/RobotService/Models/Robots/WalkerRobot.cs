using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Robots
{
    public class WalkerRobot : Robot
    {
        public WalkerRobot(string name, int happiness, int energy, int procedureTime) : base(name, happiness, energy, procedureTime)
        {
        }
    }
}

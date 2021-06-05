using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Robots
{
    public class PetRobot : Robot
    {
        public PetRobot(string name, int happiness, int energy, int procedureTime) : base(name, happiness, energy, procedureTime)
        {
        }
    }
}

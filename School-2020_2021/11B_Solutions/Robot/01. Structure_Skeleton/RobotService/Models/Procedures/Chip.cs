using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public class Chip : Procedure
    {
        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot, procedureTime);
            robot.Happiness -= 5;
            if (robot.IsChipped)
            {
                throw new ArgumentException($"{robot.Name} is already chipped");
            }
            robot.IsChipped = true;
        }
    }
}

using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Garages
{
    public class Garage : IGarage
    {
        public IReadOnlyDictionary<string, IRobot> Robots => throw new NotImplementedException();

        public void Manufacture(IRobot robot)
        {
            throw new NotImplementedException();
        }

        public void Sell(string robotName, string ownerName)
        {
            throw new NotImplementedException();
        }
    }
}

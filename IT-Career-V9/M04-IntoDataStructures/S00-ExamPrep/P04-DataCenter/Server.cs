using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataCenter
{
    public class Server 
    {
        public Server(string serialNumber, string model, int capacity, int powerUsage)
        {
            SerialNumber = serialNumber;
            Model = model;
            Capacity = capacity;
            PowerUsage = powerUsage;
        }

        public string SerialNumber { get; private set; }
        public string Model { get; private set; }
        public int Capacity { get; private set; }
        public int PowerUsage { get; private set; }

        public override string ToString()
        {
            return $"Server {SerialNumber}: {Model}, {Capacity}TB, {PowerUsage}W";
        }
    }
}

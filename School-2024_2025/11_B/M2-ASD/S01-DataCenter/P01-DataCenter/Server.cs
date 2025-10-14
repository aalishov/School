using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_DataCenter
{
    public class Server
    {
        public Server(string serialNumber, string model, int capacity, int powerUsage)
        {
            this.SerialNumber = serialNumber;
            this.Model = model;
            this.Capacity = capacity;
            this.PowerUsage = powerUsage;
        }

        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public int PowerUsage { get; set; }
        public override string ToString()
        {
            return $"Server {this.SerialNumber}: {this.Model}, {this.Capacity}TB, {this.PowerUsage}W";
        }
    }
}

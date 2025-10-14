using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_DataCenter
{
    internal class Rack 
    {
        private List<Server> servers;

        public Rack(int slots)
        {
            this.Slots= slots;
            this.servers = new List<Server>();
        }

        public int Slots { get; set; }
        public int GetCount { get { return servers.Count;  }  }
        
        public void Addserver(Server server)
        {
            if (GetCount==Slots)
            {
                return;
            }
            if (servers.Any(x=>x.SerialNumber==server.SerialNumber))
            {
                return;
            }
            servers.Add(server);
        }
        public bool RemoveServer(string SerialNumber)
        { 
            Server server = servers.FirstOrDefault(x=>x.SerialNumber==SerialNumber);
            return servers.Remove(server);
                
        }
        public string GetHighestPowerUsage()
        {
            Server server = servers.OrderBy(x=>x.PowerUsage).LastOrDefault();
            return server.ToString();
        }
        public int GetTotalCapacity()
        {
            return servers.Sum(x=>x.Capacity);
        }
        public string DeviceManager()
        {
            StringBuilder DeviceM = new StringBuilder();
            return ;
        }
    }
}

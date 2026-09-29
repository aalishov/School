using System;
using System.Collections.Generic;
using System.Text;

namespace DataCenter
{
    public class Rack
    {
        private readonly List<Server> servers;

        public Rack(int slots)
        {
            Slots = slots;
            servers = new List<Server>();
        }

        public int Slots { get; private set; }

        public IReadOnlyCollection<Server> Servers { get { return servers; } }

        public int GetCount { get { return servers.Count; } }

        public void AddServer(Server server)
        {
            //!servers.Any(s => s.SerialNumber == server.SerialNumber)
            if (servers.Count < Slots && servers.Count(x => x.SerialNumber == server.SerialNumber) == 0)
            {
                servers.Add(server);
            }
        }
        public bool RemoveServer(string serialNumber)
        {
            Server removed = servers.FirstOrDefault(x => x.SerialNumber == serialNumber);

            return servers.Remove(removed);
        }
        public string GetHighestPowerUsage()
        {
            return servers.OrderBy(x => x.PowerUsage).LastOrDefault().ToString();
        }
        public int GetTotalCapacity()
        {
            if (!servers.Any()) { return 0; }
            return servers.Sum(x => x.Capacity);
        }
        public string DeviceManager()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetCount} servers operating:");
            servers.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}

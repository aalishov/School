using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
    public class Controller
    {
        private readonly List<Village> villageList = new List<Village>();
        private readonly List<Rebel> rebelList = new List<Rebel>();
        private int totalAttacksPerformed = 0;
        public string ProcessVillageCommand(List<string> args)
        {
            string name = args[0];
            string location = args[1];
            Village village = new Village(name, location);
            villageList.Add(village);
            return $"Created Village {village}!";
        }
        public string ProcessSettleCommand(List<string> args)
        {
            string name = args[0];
            int age = int.Parse(args[1]);
            int productivity = int.Parse(args[2]);
            string villageName = args[3];
            Peasant peasant = new Peasant(name, age, productivity);
            villageList.FirstOrDefault(x => x.Name == villageName).AddPeasant(peasant);
            return $" Settled Peasant {peasant.Name} in Village {villageName}!";
        }
        public string ProcessRebelCommand(List<string> args)
        {
            string name = args[0];
            int age = int.Parse(args[1]);
            int harm = int.Parse(args[2]);
            Rebel rebel = new Rebel(name, age, harm);
            rebelList.Add(rebel);
            return $" Rebel {rebel.Name} joined the gang!";
        }
        public string ProcessDayCommand(List<string> args)
        {
            string villageName = args[0];
            return $" Village {villageName} resource increased with {villageList.FirstOrDefault(x => x.Name == villageName).PassDay()}!";
        }
        public string ProcessAttackCommand(List<string> args)
        {
            if (rebelList.Any())
            {
                int rebelCount = int.Parse(args[0]);
                string villageName = args[1];
                int takenResource = rebelList.Take(rebelCount).Sum(r => r.Harm);
                Village village = villageList.FirstOrDefault(x => x.Name == villageName);
                village.Resource -= takenResource;
                int killCount = rebelCount / 2;
                int deadPeasants = village.KillPeasants(killCount).Count;
                totalAttacksPerformed++;
                return $"Village {villageName} lost {takenResource} resources and {deadPeasants} peasants!";
            }

            return "No rebels to perform raid...";
        }
        public string ProcessInfoCommand(List<string> args)
        {
            if (args[0] == "Rebel")
            {
                if (rebelList.Any())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Rebels:");
                    foreach (var item in rebelList)
                    {
                        sb.AppendLine(item.ToString());
                    }
                    return sb.ToString().TrimEnd();
                }
                else
                {
                    return " No Rebels";
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Villages:");
                if (villageList.Any())
                {
                    foreach (var item in villageList)
                    {
                        sb.AppendLine(item.ToString());
                    }
                    return sb.ToString().TrimEnd();
                }
                else
                {
                    return "No Villages";
                }
            }
        }
        public string ProcessEndCommand()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Villages: {villageList.Count}");
            sb.AppendLine($"Rebels: {rebelList.Count}");
            sb.AppendLine($"Attacks on Villages: {totalAttacksPerformed}");
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Village
{
    public class Controller
    {
        private readonly List<Village> villages;
        private readonly List<Rebel> rebels;
        private static int totalAttacksPerformed = 0;
        public Controller()
        {
            this.villages = new List<Village>();
            this.rebels = new List<Rebel>();
        }
        public string ProcessVillageCommand(List<string> args)
        {
            string villageName = args[0];
            string location = args[1];
            this.villages.Add(new Village(villageName, location));
            return $"Created Village {villageName}!";
        }

        public string ProcessSettleCommand(List<string> args)
        {
            string peasantName = args[0];
            int age = int.Parse(args[1]);
            int productivity = int.Parse(args[2]);
            string villageName = args[3];

            Village village = this.villages.FirstOrDefault(x => x.Name == villageName);

            village.AddPeasant(new Peasant(peasantName, age, productivity));

            return $"Settled Peasant {peasantName} in Village {villageName}!";
        }

        public string ProcessRebelCommand(List<string> args)
        {
            string rebelName = args[0];
            int age = int.Parse(args[1]);
            int harm = int.Parse(args[2]);
            this.rebels.Add(new Rebel(rebelName, age, harm));

            return $"Rebel {rebelName} joined the gang!";
        }

        public string ProcessDayCommand(List<string> args)
        {
            string villageName = args[0];
            Village village = this.villages.FirstOrDefault(x => x.Name == villageName);
            int dailyResource = village.PassDay();

            return $"Village {villageName} resource increased with {dailyResource}!";
        }

        public string ProcessAttackCommand(List<string> args)
        {
            if (this.rebels.Any())
            {
                int rebelCount = int.Parse(args[0]);
                string villageName = args[1];

                int takenResource = this.rebels.Take(rebelCount).Sum(x => x.Harm);

                Village village = this.villages.FirstOrDefault(x => x.Name == villageName);
                village.Resource -= takenResource;
                int deadPeasants = village.KillPeasants(rebelCount / 2).Count;

                totalAttacksPerformed++;

                return $"Village {villageName} lost {takenResource} resources and {deadPeasants} peasants!";
            }
            return $"No rebels to perform raid...";
        }
        public string ProcessInfoCommand(List<string> args)
        {
            string side = args[0];

            if (side == "Rebel")
            {
                if (this.rebels.Any())
                {
                    return $"Rebels:{Environment.NewLine}{string.Join($"{Environment.NewLine}", this.rebels)}";
                }
                else
                {
                    return $"No Rebels";
                }
            }
            else //if (side == "Village")
            {
                if (this.villages.Any())
                {
                    return $"Villages:{Environment.NewLine}{string.Join($"{Environment.NewLine}", this.villages)}";
                }
                else
                {
                    return $"No Villages";
                }
            }
        }
        public string ProcessEndCommand()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Villages: {this.villages.Count}");
            sb.AppendLine($"Rebels: {this.rebels.Count}");
            sb.AppendLine($"Attacks on Villages: {totalAttacksPerformed}");
            return sb.ToString().TrimEnd();
            
        }

    }
}
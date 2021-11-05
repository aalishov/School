using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Village
{
    public class Controller
    {
        public List<Village> Villages = new List<Village>();
        public List<Rebel> Rebels = new List<Rebel>();
        public int attacks = 0;
        public string ProceseVillageCommand(List<string> args)
        {
            Villages.Add(new Village(args[0], args[1]));
            return $"Created Village {args[0]}!";
        }

        public string ProcessSettleCommand(List<string> args)
        {
            var name = args[0];
            var age = int.Parse(args[1]);
            var productivity = int.Parse(args[2]);
            var villageName = args[3];
            Peasant peasant = new Peasant(name, age, productivity);
            Villages.FirstOrDefault(x => x.Name == villageName).AddPeasant(peasant);
            return $"Settled Peasant {name} in Village {villageName}!";
        }

        public string ProcessRebelCommand(List<string> args)
        {
            var name = args[0];
            var age = int.Parse(args[1]);
            var harm = int.Parse(args[2]);
            Rebel rebel = new Rebel(name, age, harm);
            Rebels.Add(rebel);
            return $"Rebel {name} joined the gang!";
        }

        public string ProcessDayCommand(List<string> args)
        {
            var resources = Villages.FirstOrDefault(x => x.Name == args[0]).PassDay();
            return $"Village {args[0]} resource increased with {resources}!";
        }

        public string ProcessAttackCommand(List<string> args)
        {
            if (Rebels.Count == 0)
            {
                return "No rebels to perform raid...";
            }

            var rebelAttack = Rebels.GetRange(0, int.Parse(args[0]));
            var rebelAttackDamage = rebelAttack.Sum(x => x.Harm);
            Villages.FirstOrDefault(x => x.Name == args[1]).Resource -= rebelAttackDamage;
            var rebelsCount = (int)(rebelAttack.Count / 2);
            var deadPeasants = Villages.FirstOrDefault(x => x.Name == args[1]).KillPeasants(rebelsCount);
            attacks++;
            return $"Village {args[1]} lost {rebelAttackDamage} resources and {deadPeasants.Count} peasants!";
        }
        public string ProcessInfoCommand(List<string> args)
        {
            StringBuilder stb = new StringBuilder();
            if (args[0] == "Rebel")
            {
                if (Rebels.Count == 0)
                {
                    stb.AppendLine("No Rebels");
                }
                else
                {
                    stb.AppendLine("Rebels:");
                    foreach (var item in Rebels)
                    {
                        stb.AppendLine(item.ToString());
                    }
                }

            }
            else if (args[0] == "Village")
            {
                if (Villages.Count == 0)
                {
                    stb.AppendLine("No Villages");
                }
                else
                {
                    stb.AppendLine("Villages:");
                    foreach (var item in Villages)
                    {
                        stb.AppendLine(item.ToString());
                    }
                }
            }
            return stb.ToString();
        }

        public string ProcessEndCommand()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine($"Villages: {Villages.Count}");
            stb.AppendLine($"Rebels: {Rebels.Count}");
            stb.AppendLine($"Attacks on Villages: {attacks}");
            return stb.ToString();
        }

    }
}
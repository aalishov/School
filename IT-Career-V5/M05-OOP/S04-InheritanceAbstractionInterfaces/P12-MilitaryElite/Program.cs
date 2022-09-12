namespace MilitaryElite
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        private static Dictionary<int, Soldier> soldiers = new Dictionary<int, Soldier>();
        public static void Main()
        {
            try
            {
                CreateSoldiers();

                PrintSoldiersInfo();
            }
            catch (Exception)
            {
               
            }
 
        }

        private static void PrintSoldiersInfo()
        {
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.Value);
            }
        }

        private static void CreateSoldiers()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split(' ');
                string type = info[0].ToLower();
                int id = int.Parse(info[1]);
                string firstName = info[2];
                string lastName = info[3];
                decimal salary = decimal.Parse(info[4]);

                Soldier soldier = null;

                switch (type)
                {
                    case "private":
                        soldier = new Private(id, firstName, lastName, salary);
                        break;
                    case "lieutenantgeneral":
                        List<Private> privates = new List<Private>();
                        for (int i = 5; i < info.Length; i++)
                        {
                            int privateId = int.Parse(info[i]);
                            if (soldiers.ContainsKey(privateId))
                            {
                                privates.Add((Private)soldiers[privateId]);
                            }
                        }
                        soldier = new LieutenantGeneral(id, firstName, lastName, salary, privates);
                        break;
                    case "engineer":
                        string corp = info[5];
                        List<Repair> repairs = new List<Repair>();
                        for (int i = 6; i < info.Length; i += 2)
                        {
                            string part = info[i];
                            int hour = int.Parse(info[i + 1]);
                            repairs.Add(new Repair(part, hour));
                        }
                        try
                        {
                            soldier = new Engineer(id, firstName, lastName, salary, corp, repairs);

                        }
                        catch (Exception ex)
                        {
                            //Console.WriteLine(ex.Message);
                        }
                        break;
                    case "commando":
                        corp = info[5];
                        List<Mission> missions = new List<Mission>();

                        for (int i = 6; i < info.Length; i += 2)
                        {
                            string codeName = info[i];
                            string state = info[i + 1];
                            try
                            {
                                missions.Add(new Mission(codeName, state));
                            }
                            catch (Exception ex)
                            {
                                //Console.WriteLine(ex.Message);
                            }
                        }
                        soldier = new Commando(id, firstName, lastName, salary, corp, missions);
                        break;
                    case "spy":
                        int codeNumber = int.Parse(info[5]);
                        soldier = new Spy(id, firstName, lastName, codeNumber);
                        break;
                }
                if (soldier != null)
                {
                    soldiers.Add(id, soldier);
                }
            }
        }
    }
}

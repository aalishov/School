namespace MilitaryElite
{
    using System.Collections.Generic;
    using System.Text;

    public class Commando : SpecialisedSoldier, ICommando
    {
        private readonly List<Mission> missions;
        public Commando(int id, string firstName, string lastName, decimal salary, string corps, List<Mission> missions) : base(id, firstName, lastName, salary, corps)
        {
            this.missions = missions;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");
            missions.ForEach(mission => sb.AppendLine("  " + mission.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}

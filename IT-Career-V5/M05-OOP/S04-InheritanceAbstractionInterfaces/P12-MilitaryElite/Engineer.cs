namespace MilitaryElite
{
    using System.Collections.Generic;
    using System.Text;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private readonly List<Repair> repairs;
        public Engineer(int id, string firstName, string lastName, decimal salary, string corps, List<Repair> repairs) : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = repairs;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            this.repairs.ForEach(x => sb.AppendLine("  " + x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}

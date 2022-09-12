namespace MilitaryElite
{
    using System.Collections.Generic;
    using System.Text;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly List<Private> privates;
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, List<Private> privates) : base(id, firstName, lastName, salary)
        {
            this.privates = privates;
        }
        public IReadOnlyCollection<Private> Privates
        {
            get { return this.privates.AsReadOnly(); }
        }
        public void AddPrivate(Private @private)
        {
            this.privates.Add(@private);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            //foreach (var @private in privates)
            //{
            //    sb.AppendLine(@private.ToString());
            //}
            this.privates.ForEach(x => sb.AppendLine("  " + x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}

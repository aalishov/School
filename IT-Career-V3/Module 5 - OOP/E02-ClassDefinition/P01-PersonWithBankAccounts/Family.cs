using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_PersonWithBankAccounts
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            members = new List<Person>();
        }
        public List<Person> Members
        {
            get { return members; }
            set { members = value; }
        }

        public string PrintFamilyAsc()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var m in members.OrderBy(x=>x.Name))
            {
                sb.AppendLine($"{m.Name} - {m.Age}");
            }
            return sb.ToString().TrimEnd();
        }

        public string PrintFamilyOver30Asc()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var m in members.Where(x=>x.Age>30).OrderBy(x => x.Name))
            {
                sb.AppendLine($"{m.Name} - {m.Age}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_BorderControl
{
    public abstract class BaseCitizen
    {
        protected BaseCitizen(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public bool IsValid(string invalidIdEnd)
        {
            string end = Id.Substring(Id.Length -invalidIdEnd.Length);
            if (end==invalidIdEnd)
            {
                return false;
            }
            return true;
        }
    }
}

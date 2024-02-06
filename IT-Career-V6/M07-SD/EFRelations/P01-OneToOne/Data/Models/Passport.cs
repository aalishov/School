using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_OneToOne.Data.Models
{
    public class Passport
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public virtual Person Person { get; set; }
    }
}

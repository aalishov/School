using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_OneToOne.Data.Models
{
    public class Passport
    {
        public int Id { get; set; }

        [MaxLength(8)]
        public string Number { get; set; }

        public virtual Person Person { get; set; }
    }
}

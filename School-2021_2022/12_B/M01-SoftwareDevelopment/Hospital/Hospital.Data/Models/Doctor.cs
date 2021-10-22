using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Data.Models
{
   public class Doctor
    {
        public Doctor(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public string Name { get; set; }

        public string Position { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_BorderControl
{
    public class Robot:BaseCitizen
    {
        public Robot(string id, string model) : base(id)
        {
            this.Model = model;
        }

        public string Model { get; set; }
    }
}

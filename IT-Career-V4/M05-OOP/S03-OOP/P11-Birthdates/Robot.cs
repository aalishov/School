using System.Collections.Generic;

namespace P11_Birthdates
{
    public class Robot : BaseCitizen, IModel
    {
        public Robot(string id, string model) : base(id)
        {
            this.Model = model;
            
        }
        public Robot(string id) : base(id)
        { 
            this.Model = "AX-15";
        }

        public string Model { get ; set; }
    }
}

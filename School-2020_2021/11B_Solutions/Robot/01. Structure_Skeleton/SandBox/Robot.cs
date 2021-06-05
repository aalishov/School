using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox
{
    public class Robot
    {
        private string name;

        public Robot(string name)
        {
            this.Name = name;
        }

        public void PrintName()
        { 
            Console.WriteLine(this.name); 
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            return $"My name is {this.Name}";
        }
    }
}
